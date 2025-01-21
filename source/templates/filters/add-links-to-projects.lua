-- This filter adds a "download" link to all the CodeBlock elements
-- that have a "download" attribute with a non-empty value.
-- https://pandoc.org/lua-filters.html#type-codeblock

return {
    {
        CodeBlock = function(el)
            if el.attributes.download ~= nil then
                link = el.attributes.download -- We save the link before removing this attribute from the element.
                el.attributes.download=nil    -- removing the download attribute from the element altogether.
                return {
                    el,
                    pandoc.Link(
                        pandoc.Emph("(Download this code)"),
                        link,
                        "Download a project containing this snippet."
                        -- ,  {class = "download-button"} -- unfortunately, Quartz (Github Flavored Markdown // Obsidian Flavored Markdown)
                        -- does not seem to support classes.
                    )
                }
            end
        end
    }
}

