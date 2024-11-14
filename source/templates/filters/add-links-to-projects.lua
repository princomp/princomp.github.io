-- This filter adds a "download" link to all the CodeBlock elements
-- that have a "download" attribute with a non-empty value.
-- https://pandoc.org/lua-filters.html#type-codeblock

return {
    {
        CodeBlock = function(el)
            if el.attributes.download ~= nil then
                return {
                    el,
                    pandoc.Link(
                        pandoc.Emph("(Download this code)"),
                        el.attributes.download,
                        "Download a project containing this snippet.",
                        {class = "download-button"}
                    )
                }
            end
        end
    }
}
