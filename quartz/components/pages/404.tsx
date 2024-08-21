import { i18n } from "../../i18n"
import { QuartzComponent, QuartzComponentConstructor, QuartzComponentProps } from "../types"

const NotFound: QuartzComponent = ({ cfg }: QuartzComponentProps) => {
  // If baseUrl contains a pathname after the domain, use this as the home link
  const url = new URL(`https://${cfg.baseUrl ?? "example.com"}`)
  const baseDir = url.pathname

  return (
    <article class="popover-hint">
      <h1>404</h1>
      <p>{i18n(cfg.locale).pages.error.notFound}</p>
      <p>Please, <a href="https://github.com/princomp/princomp.github.io/issues/new?body=The+following+page+is+in+error+(_please,+insert+here+the+address+of+the+page+you+were+trying+to+access_).&title=Link+in+error+on+website">report the issue on github</a>.</p>
      {
                // Link generated using https://github.com/sindresorhus/new-github-issue-url
      }
      <a href={baseDir}>{i18n(cfg.locale).pages.error.home}</a>
    </article>
  )
}

export default (() => NotFound) satisfies QuartzComponentConstructor
