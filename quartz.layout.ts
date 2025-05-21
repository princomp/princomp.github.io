import { PageLayout, SharedLayout } from "./quartz/cfg"
import * as Component from "./quartz/components"

import { Options } from "./quartz/components/Explorer"
// import { nameOrderMap } from "./content/web-order"

export const filterFn: Options["filterFn"] = (node) => {	
    return node.slug?.startsWith("solutions") !== true
}

export const sortFn: Options["sortFn"] = (a, b) => {
  const nameOrderMap: Record<string, number> = {
		"docs/index.md": 1,
		"docs/about/index.md": 2,
		"docs/about/credits.md": 3,
		"docs/about/contributing.md": 4,
		"docs/about/dev_guide.md": 5,
		"docs/academic_life/index.md": 6,
		"docs/academic_life/getting_help.md": 7,
		"docs/academic_life/choosing_major.md": 8,
		"docs/academic_life/ca.md": 9,
		"docs/academic_life/uca_guide.md": 10,
		"docs/programming_and_computer_usage/index.md": 11,
		"docs/programming_and_computer_usage/computer_requirements.md": 12,
		"docs/programming_and_computer_usage/installing_software.md": 13,
		"docs/programming_and_computer_usage/unzipping_archives.md": 14,
		"docs/programming_and_computer_usage/keyboard_shortcuts.md": 15,
		"docs/programming_and_computer_usage/datatypes_in_csharp.md": 16,
		"docs/programming_and_computer_usage/uml_class.md": 17,
		"lectures/index.md": 18,
		"lectures/intro/index.md": 19,
		"lectures/intro/computers_and_programming.md": 20,
		"lectures/intro/csharp_fundamentals.md": 21,
		"lectures/intro/datatypes_and_variables.md": 22,
		"lectures/intro/operators.md": 23,
		"lectures/intro/conversions.md": 24,
		"lectures/intro/inputs_and_outputs.md": 25,
		"lectures/oop/index.md": 26,
		"lectures/oop/oop_intro.md": 27,
		"lectures/oop/constructors_methods.md": 28,
		"lectures/oop/properties.md": 29,
		"lectures/oop/static.md": 30,
		"lectures/oop/generic_types.md": 31,
		"lectures/oop/inheritance.md": 32,
		"lectures/oop/polymorphism.md": 33,
		"lectures/oop/abstract.md": 34,
		"lectures/oop/interface.md": 35,
		"lectures/control/index.md": 36,
		"lectures/control/flow_intro.md": 37,
		"lectures/control/booleans.md": 38,
		"lectures/control/ifs.md": 39,
		"lectures/control/switch.md": 40,
		"lectures/control/while.md": 41,
		"lectures/control/do_while.md": 42,
		"lectures/control/input_validation.md": 43,
		"lectures/control/foreach.md": 44,
		"lectures/control/for_loop.md": 45,
		"lectures/control/vocabulary.md": 46,
		"lectures/control/control_flow_and_classes.md": 47,
		"lectures/control/break_continue.md": 48,
		"lectures/control/conditional_operator.md": 49,
		"lectures/control/recursion.md": 50,
		"lectures/control/more_on_recursion.md": 51,
		"lectures/collections/index.md": 52,
		"lectures/collections/intro.md": 53,
		"lectures/collections/1d.md": 54,
		"lectures/collections/loop_length.md": 55,
		"lectures/collections/default_resizing.md": 56,
		"lectures/collections/search.md": 57,
		"lectures/collections/arrays_of_objects.md": 58,
		"lectures/collections/manipulating_rectangular_arrays.md": 59,
		"lectures/collections/lists.md": 60,
		"lectures/collections/CList.md": 61,
		"lectures/misc/index.md": 62,
		"lectures/misc/over_under_flow.md": 63,
		"lectures/misc/random.md": 64,
		"lectures/misc/exceptions.md": 65,
		"lectures/misc/references.md": 66,
		"lectures/misc/files.md": 67,
		"lecture/slides.md": 68,
		"labs/index.md": 69,
		"exercises/index.md": 70,
		"exercises/introduction/index.md": 71,
		"exercises/introduction/datatypes.md": 72,
		"exercises/introduction/strings.md": 73,
		"exercises/introduction/numerical.md": 74,
		"exercises/introduction/io.md": 75,
		"exercises/oop/index.md": 76,
		"exercises/oop/properties.md": 77,
		"exercises/oop/references.md": 78,
		"exercises/oop/inheritance.md": 79,
		"exercises/oop/objects.md": 80,
		"exercises/oop/oop.md": 81,
		"exercises/oop/operations.md": 82,
		"exercises/oop/structures.md": 83,
		"exercises/misc/index.md": 84,
		"exercises/misc/exceptions.md": 85,
		"exercises/io/index.md": 86,
		"exercises/io/files.md": 87,
		"exercises/collections/index.md": 88,
		"exercises/collections/1darrays.md": 89,
		"exercises/collections/2darrays.md": 90,
		"exercises/control/index.md": 91,
		"exercises/control/conditionals.md": 92,
		"exercises/control/iteratives.md": 93,
		"exercises/control/recursion.md": 94,
		"projects/index.md": 95,
		"projects/submission.md": 96,
		"projects/todo_list.md": 97,
		"projects/throw_count.md": 98,
		"projects/temp_stats.md": 99,
		"projects/bookmarker.md": 100,
		"projects/evaluation.md": 101,
		"projects/species.md": 102,
		"projects/file_displayer.md": 103,
		"projects/texfilehelper.md": 104,
	}
    return (nameOrderMap[a.data.filePath] || 0)- (nameOrderMap[b.data.filePath] || 0)
  }

// components shared across all pages
export const sharedPageComponents: SharedLayout = {
  head: Component.Head(),
  header: [],
  afterBody: [],
  footer: Component.Footer({
    links: {
      "Credits" : "/docs/about/credits",
      "Source": "https://github.com/princomp/princomp.github.io",
      "CC BY 4.0": "/docs/about/credits#licence",
      "Discord": "https://discord.com/invite/AYSw3UNKEh",
    }})
}

// components for pages that display a single page (e.g. a single note)
export const defaultContentPageLayout: PageLayout = {
  beforeBody: [
    Component.ConditionalRender({
      component: Component.Breadcrumbs(),
      condition: (page) => page.fileData.slug !== "index",
    }),
    Component.ArticleTitle(),
    Component.ContentMeta(),
    Component.AlternativeFormats(),
    Component.TagList(),
  ],
  left: [
    Component.PageTitle(),
    Component.MobileOnly(Component.Spacer()),
    Component.Flex({
      components: [
        {
          Component: Component.Search(),
          grow: true,
        },
        { Component: Component.Darkmode() },
        { Component: Component.ReaderMode() },
      ],
    }),
    Component.Explorer({filterFn, sortFn}),
  ],
  right: [
    Component.Graph(),
    Component.DesktopOnly(Component.TableOfContents()),
    Component.Backlinks(),
  ],
}

// components for pages that display lists of pages  (e.g. tags or folders)
export const defaultListPageLayout: PageLayout = {
  beforeBody: [Component.Breadcrumbs(), Component.ArticleTitle(), Component.ContentMeta()],
  left: [
    Component.PageTitle(),
    Component.MobileOnly(Component.Spacer()),
    Component.Flex({
      components: [
        {
          Component: Component.Search(),
          grow: true,
        },
        { Component: Component.Darkmode() },
      ],
    }),
    Component.Explorer({filterFn, sortFn}),
  ],
  right: [],
}
