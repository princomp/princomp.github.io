-- This filter is an adaptation of
-- https://codereview.stackexchange.com/questions/288003/pandoc-lua-filter-to-prefix-absolute-paths-of-links-and-images

pathPrefixMetaName = "pathToProjectRoot"

-- Global variable to store path prefix once it has been
-- extracted from the metadata
pathPrefix = nil

-- Traversal should run top down, in order for the
-- Meta function to be called before Link or Image
-- functions. Otherwise the path prefix is not known
-- when the Link/Image functions are run.
traverse = 'topdown'

-- Utility function with prepends paths with the path prefix
local function prefix_path(p)
    return pandoc.path.normalize(pathPrefix .. "/" .. p)
end

-- Adjust relative (that is, not absolute) link targets
function Link(l)
    if (not pathPrefix or pandoc.path.is_absolute(l.target)) then return end
    if l.target:sub(1, 2) == "./" then
    -- We test if the link starts with "./": if it does, we trigger the prefixing.
        local new_link = l:clone()
        new_link.target = prefix_path(l.target)
        return new_link
    end
end

-- Optimize traversal, stop if no meta variable available
function Blocks(p)
    if not pathPrefix then return nil, false end
end

-- Extract required meta variable
function Meta(m)
    local meta_var = m[pathPrefixMetaName]
    if not meta_var then return nil, false end
    if type(meta_var) == "string" then
        -- When specified via command line option -M, then
        -- the meta variable will be a bare string
        pathPrefix = meta_var
    elseif type(meta_var) == "table"
        and type(meta_var[1]) == "userdata"
        and pandoc.utils.type(meta_var[1]) == "Inline" then
        -- When specified via YAML, then the meta variable
        -- will be a pandoc [Str "path/"]
        pathPrefix = meta_var[1].text
    end
end
