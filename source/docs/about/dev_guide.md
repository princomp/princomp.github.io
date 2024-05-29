---
tags:
- Resource
- Guide
---

# Dev. Guide

This guide explains how this resource is organized, how it is built and deployed, and how to maintain this resource.

| ⚠️ Warning |
|:---------------------------|
| This resource is currently under heavy remodelling. This documentation will be updated but is outdated in places as of this writing. |

## Resources Organization Overview

### Folders and Files

The [source code repository](https://github.com/princomp/princomp.github.io)'s main branch is organized as follows:

path | description
--- | ---
`.github/` | github templates and configuration for github actions
`misc/` | resources that need to be either integrated into the resource, or discarded
`source/`| source for the material
`licence.md` | license file
`readme.md` | presentation of the repository.

The `source/` folder contains the following:

path | description
------ | --- 
`code/` | code examples (snippets and projects)
`docs/` | additional helpful documentation
`fonts/` | the fonts (redistributed with permission) used by this resource
`img/` | images, sometimes with their LaTeX source code
`labs/` | lab exercises
`lectures/` | lecture notes
`slides/` | slides
`templates/` | templates, filters and fonts files used for building this resource
`vid/` | video files
`Makefile` | makefile used to compile this resource
`index.md` | website index page
`order` | file used to specify the order on the website's menu and the book

### Building and Deploying

The content is built and deployed in two phases:

- Running `make all` in the `source/` folder will create a `content/` folder at root level containing:
    - one `.md` file per `.md` file in the `source/` folder (in the same location: `source/labs/If.md` is compiled to `content/labs/If.md`), resulting from [pandoc](https://pandoc.org/)'s conversion,
    - one `.pdf`, `.odt` and `.docx` file per `.md` file (with the exception of the `index.md` files) in the `source/` folder (in the same location: `source/labs/If.md` is compiled to `content/labs/If.pdf`), resulting from [pandoc](https://pandoc.org/)'s conversion,
    - some files (in `img/`, `slides/`, `vid/`, `templates/`) copied verbatim or selectively (for example, only the `.jpeg`, `.png`, `.pdf`, `.svg` and `.gif` files are copied from the `img` folder),
    - the `.woff` and `.woff2` files copied from the `templates/fonts` folders,
    - a `code/projects` folder containing, for each `Program.cs` file contained in a `source/code/project/x/y`, a `x.zip` archive containing a C# project including `Program.cs` along with some (optional) class file,
    - a `web-order.ts` file, compiled from the `source/order` file, that fixes the order used by the website in the menu,
    - a `book.html`, a `book.pdf`, a `book.html` and a `book.docx` file resulting from [pandoc](https://pandoc.org/)'s conversion of the `.md` files contained in the `SOURCE_BOOK`'s makefile variable (containing all the `.md` files in the `source/docs/` and  `source/lectures/`, in the order fixed by the `order` file).
- Then, using the files in the generated `content/` folder, a website is built using [quartz](https://quartz.jzhao.xyz/) and deployed to <https://princomp.github.io/>. This is achieved mainly thanks to the `.github/workflows/build_and_deploy.yaml` file and [github's actions](https://docs.github.com/en/actions).

### Tools, Briefly

This resource is mainly developed and powered using 

- [git](https://git-scm.com/)
- [pandoc](https://pandoc.org/installing.html)
- [make](https://www.gnu.org/software/make/)
- [python](https://www.python.org)
- [quartz](https://quartz.jzhao.xyz/), 
- [github's actions](https://docs.github.com/en/actions).

While most of those tools are fairly standard (with the exception of quartz, but it relies itself on the fairly standard [Node](https://nodejs.org/) and `npm` technologies), we acknowledge that

#. It is challenging to understand that many different technologies,
#. We should strive to welcome contributions from collaborators not familiar with them,
#. Our set-up is unique in some respects.

This guide tries to alleviate some challenges resulting from this overall unique and diverse resource organization.

### Locating Resources

To obtain the latest version of this resource, you can either

- visit the accompanying website [princomp.github.io](https://princomp.github.io),
- download [the latest version of the built resource](https://github.com/princomp/princomp.github.io/releases/download/latest/release.zip),
- clone [our repository](https://github.com/princomp/princomp.github.io/).

This resource is an extension of [csci-1301.github.io/](https://csci-1301.github.io/), please refer to [their user guide](https://csci-1301.github.io/user_guide.html#locating-course-resources) for more information about it.

## Editing Resources

If you are new to this project, first read through [Contributing Guidelines](/contributing) to learn how you can contribute to the improvement of this resource, and if applicable, how to join a contributing team.

### Best practices for all forms of content

#### Inclusivity

Follow the [IT Inclusive Language Guide](https://itconnect.uw.edu/guides-by-topic/identity-diversity-inclusion/inclusive-language-guide/) from the University of Washington:

>  use gender-neutral terms; avoid ableist language; focus on people not disabilities or circumstances; avoid generalizations about people, regions, cultures and countries; and avoid slang, idioms, metaphors and other words with layers of meaning and a negative history.

Typically, we recommend using "unethical hacker" instead of "black hat", "main" instead of "master", "blank space" instead of "white space", "display on the screen" instead of "printing", etc.
In doubt, please start by referring to [this list of problematic words and phrases](https://itconnect.uw.edu/guides-by-topic/identity-diversity-inclusion/inclusive-language-guide/#list).

#### Structure for accessibility

- All resources are titled
    - title each markdown document by having one (and only one) title at top level (that is, using `#`),
    - use subtitles when appropriate,
    - title all images with a descriptive title and add an alt-tag,
    - title all code blocks in labs and lecture notes.
- All resources are labelled when applicable, see [content labelling](#content-labelling) for more details

Resources to assess accessibility:

- [Affordable Learning Georgia's guide](https://alg.manifoldapp.org/projects/oer-accessibility-series-and-rubric)
- [Specific Review Standards from the QM Higher Education Rubric](https://www.qualitymatters.org/sites/default/files/PDFs/StandardsfromtheQMHigherEducationRubric.pdf)
- [UWG Accessibility Services's guide](https://docs.google.com/document/d/16Ri1XgaXiGx28ooO-zRvYPraV3Aq3F5ZNJYbVDGVnEA/edit?ts=57b4c82d#)
- [Penn State's recommendations for alternative text and complex images.](https://accessibility.psu.edu/images/)       
- [WebAim Color Contrast Checker](https://webaim.org/resources/contrastchecker/)
- [WebAIM (Web Accessibility In Mind)](https://webaim.org/)
 
#### Markdown

Text documents are written using [standard markdown syntax](https://commonmark.org/). More precisely, 

- in the `markdown+emoji` format, that is, [in pandoc's markdown](https://pandoc.org/MANUAL.html#pandocs-markdown), using the [emoji](https://pandoc.org/MANUAL.html#extension-emoji) [extension](https://pandoc.org/MANUAL.html#extensions)),
- using the [pandoc-include](https://github.com/DCsunset/pandoc-include) filter,
- and a [custom](https://github.com/princomp/princomp.github.io/tree/main/source/templates/filters) filter that sets all the [code blocks](https://github.com/princomp/princomp.github.io/blob/main/source/templates/filters/default-code-class-block.lua), or [all the code block and inline code](https://github.com/princomp/princomp.github.io/blob/main/source/templates/filters/default-code-class-block-inline.lua)'s syntax highlighting to C# by default.


#### Images

- Images belong in `source/img/` directory.
- Explain the image in written form.
- Title each image, this will create a URL for the image and enables linking to it.
- Always include a descriptive alt tag for accessibility.
- [Do not rely on everyone seeing colors the same way](https://www.wikiwand.com/en/Color_blindness).
- Prefer scalable vector images.
- When referring to images in markdown, use path from root, see example below

**Syntax example.** The quoted text is the alt tag and in parentheses is path to file

```
!["image of visual studio IDE"](./img/vs_ide.jpg){ width=80% }
```

The `{ width=80% }` attribute is optional.

#### Source code

- Source code programs belong in `source/code/` directory.
- The code included in this directory should either be:
    - Placed in the `snippets/` sub-folder, and be a complete program.
    - Placed in the `projects/<solution>/<project>/` sub-folder, and contains a `Program.cs` file:
        - Go to `source/code/projets/`,
        - Create a subdirectory with the name of the solution you would like to use,
        - Create a subdirectory with the name of the project you would like to use,
        - Create a file called `Program.cs` in 
        ```text
        source/code/projects/<solution>/<project>/Program.cs
        ```
        - If you want to add additional classes, add them in `code/projects/<solution>/<project>/<Class>.cs` files. 
    
        Do **not** add solution (`sln`) or project (`csproj`) files: they will be created automatically using the project and solution's name you specified (and a makefile rule [similar to this one](https://github.com/csci-1301/C-Sharp-project-maker)), if multiple classes are present they will all be linked, and the resulting archive will be hosted at `content/code/projects/<solution>.zip`.

- Source code that is faulty, partial, or does not terminate can be included in markdown as inline code block.
<!--
- We can automatically check these code snippets for syntactical correctness if these guidelines are followed
-->

Code snippets can be included in markdown documents using [pandoc-include](https://github.com/DCsunset/pandoc-include) filter:

    <pre>
    ```
    !include code/sample.cs
    ```
    </pre>

    Note that for [an unknown reason](https://github.com/DCsunset/pandoc-include/issues/45), no special characters (such as `_`) should be used in the filenames.
- Title each source code block included in markdown, this will create a URL for the code block and enables linking to it.
- code blocks are by default annotated as `csharp`
    - syntax highlighting is applied automatically at build time based on the code block language
    - to use a language other than C\#, specify the language locally in the specific code block:

    <pre>
    ```text
    This will be treated as plain text without highlighting
    ```
    </pre>

- only include code in text form such that it can be copy-pasted for reuse
- make sure to include blank lines before and after code blocks, since the absence of these can cause the code block to display incorrectly.

### Creating new lectures

Lecture notes belong to the `source/lectures/` directory.

To create a new lecture, e.g. `lecture xyz`:

#. Create a directory corresponding to the theme if it does not exist already (say, `exceptions`), under `source/lectures/` directory

    - Follow the existing pattern for naming convention which is lowercase and separation by underscores. 
    - At the root of this folder, create an `index.md` file (so, at `source/lectures/exceptions/index.md`) containing
    
        ```text
        ---
        title: Desired Title for Theme
        ---
        ```
        so that your theme will be labeled "Desired Title for Theme" on the website's menu (see [content labelling](#content-labelling) on how to further label it).

#. Under the directory corresponding to your theme, create a file named after the lecture's title (e.g., `exception-handling.md`) in lowercase. Write lecture notes in this file [using markdown](#markdown).
#. Edit the `source/order` file and insert where appropriate
    - `./lectures/exception/` (if you created a folder called `exception`),
    - `./lectures/exception/exception-handling.md` (which *must be* between `./lectures/exception/` and the next `./lectures/xyz/` folder).
    
    This last step will insure that your lecture is 1. included in the book, 2. sorted correctly on the website's menu (the default ordering is alphabetical).

Following these steps will automatically include the new lecture in the book. 

If the lecture does not appear, here are the steps for troubleshooting the issue:
 
#. Check that after committing changes, the automated build has completed successfully, by checking [the workflows](https://github.com/princomp/princomp.github.io/actions),
#. The newly created lecture is under the subdirectory you picked in the [`source/lectures/` directory](https://github.com/princomp/princomp.github.io/tree/main/source/lectures),
#. The `.md` file exists,
#. Hard refresh the browser page if viewing the resources website

**Known issues**: When concatenating files pandoc may or may not include empty spaces between individual files. This may cause the subsequent lecture title to not appear in the generated book. For this reason, each lecture file should end with a newline.

### Creating new labs

The process is very close to [the process to create a new lecture](#creating-new-lectures), with the following exceptions:

- All lab resources are located under `source/labs/` directory, at root level (there is no "theme" sub-folder).
- You do not need to edit the `source/order` file, since labs are not included in the book nor sorted on the website.

Additionally, remember to:

#. Choose a short and unique name that describes the lab (say, `StringMethods.md`)
    - follow the existing convention for naming,
    - do not number labs or make assumptions about numbering because another instructor may not follow the exact same lab order,
    - make the lab standalone to support alternative ordering (avoid assumptions about what was done "last time"),
    - do not make assumptions about student using specific OS, include instructions for all supported options (Windows, MacOS, Linux),
    - do not make assumptions about student using Visual Studio, refer to IDE instead.
    
#. (optional) You can add a downloadable project (use a link of the form `[the Rectangle project](./code/projects/Rectangle.zip)`) or include snippets of code by following [our instructions to add source code](#source-code). 

Using this established build system generates labs that are cross-platform (Windows, MacOS, Linux) and work on different IDEs (this process is documented [in the corresponding repository](https://github.com/csci-1301/C-Sharp-project-maker)).
Do not attempt to create labs locally as that approach does not have the same cross-platform guarantee.

### Content Labelling

[Quartz](https://quartz.jzhao.xyz/authoring-content#syntax) support a powerful [tagging system](https://quartz.jzhao.xyz/features/folder-and-tag-listings#tag-listings) which should be leveraged.
Markdown files can contain at their very top a [YAML metadata block](https://pandoc.org/MANUAL.html#extension-yaml_metadata_block) containing, e.g.

```yaml
---
tags:
- Resource
---
```

to "tag" this resource with "Resource" so that it will appears in the [tag listing](https://princomp.github.io/tags/Guide).
To include multiple tags, simply make a list:
```yaml
---
tags:
- Resource
- Guide
---
```

<!--
| Description | Shortcode | Icon |
| : |  |  |
| Security related aspects will be labelled as "security" | `:shield:` | 🛡 |
| Optional parts will be labelled as "optional" | `:question:` | ❓ |
| Elements to be incorporated in the future as "soon" | `:soon:` | 🔜 | 
-->
<!--
| Examples of common pitfalls | `:warning:` | ⚠️ |
-->

## Styling and Templating

Templating files are under `source/templates/` directory.

Templates directory specifies layout files and stylesheets used in the website. These layouts are applied by pandoc when resources are built.

For maintainability reasons it is preferable to apply templates during build time. This strategy makes it easy to edit templates later and apply those changes across all resources. Avoid applying templating to individual resource files whenever possible.

Currently templates directory contains the following:

- `docx/` - contains template used to produce `.docx` files (this template is not used yet, for [size issues](https://github.com/csci-1301/csci-1301.github.io/issues/156)).
- `filters/` - contains pandoc filters for annotating code blocks, configured to default to C\#, which then allows applying syntax highlighting to all code block.
- `html/` - contains template used to produce *only the book.html file* (to edit the style of the website, refer to [editing website](#editing-website))
- `latex` - contains templates used to produce `.pdf` files,
- `docx/` - contains template used to produce `.odt` files.

### Updating docx template

*Note that this template is not used yet, for (among other) [size issues](https://github.com/csci-1301/csci-1301.github.io/issues/156).*

To edit this template, start by obtaining the default template file:

```{bash}
pandoc -o custom-reference.docx --print-default-data-file reference.docx
```

Then, open `reference.docx`, and, following loosely [this tutorial](https://support.microsoft.com/en-us/office/customize-or-create-new-styles-d38d6e47-f6fc-48eb-a607-1eb120dec563?ui=en-us&rs=en-us&ad=us), do:

- Click pretty much anywhere, and right-click on the highlighted style (displayed if you are under "Home", you may need to scroll down the styles),
- Change the font for everything but the source code,
- Click on the "Block code", then right-click on the highlighted style, and select the font for the source code,
- The font for "Verbatim Char" was also changed, but I am not sure if this has an impact,
- [Make sure the fonts are embedded](https://support.microsoft.com/en-us/office/benefits-of-embedding-custom-fonts-cb3982aa-ea76-4323-b008-86670f222dbc),
- Save and close the document.

This was inspired by [this post](https://stackoverflow.com/a/70513063) but does not seem to work properly.

### Updating odt template

First, output the default template file:

```{bash}
pandoc -o custom-reference.odt --print-default-data-file reference.odt
```

Then, open `reference.odt`, and, following loosely [this tutorial](https://github.com/jgm/pandoc/wiki/Defining-custom-DOCX-styles-in-LibreOffice-(and-Word)#libreoffice), do:

- Click on View, then Styles.
- Right-click on "Preformatted Text", click on "Modify…", and then select the desired font family for source code.
- In the dialog or sidebar which opens make sure the button in the top panel marked with ¶ is highlighted (it is very subtle).
- In the menu at the bottom of the dialog/sidebar choose Applied Styles. Only "Default Paragraph Style" and "Footer" should appear.
- Right-click on "Default Paragraph Style", click on "Modify…", and then select the desired font family for the rest of the text.
- Then, highlight the A next to ¶.
- Right-click on "Source_Text", click on "Modify…", and then select the desired font family for source code.
- Click on File, then Properties, then on the Font tab, click on "Embed fonts in the document".
- Save and close the document.

## Building locally

It is generally not necessary to build this resource locally unless the intent is to preview templating changes or to make changes to build scripts.
For the purposes of editing content, it is sufficient to make edits to markdown files and commit those changes. 

#### Installing dependencies

To find the current list of dependencies needed to build this resource, refer to the [build script install section](https://github.com/princomp/princomp.github.io/blob/main/.github/workflows/build.yaml#L33-L40), which lists all required packages needed to build the resource. The exact installation steps vary depending on your local operating system.

In general the following dependencies are needed:

- [pandoc](https://pandoc.org/installing.html)
- [texlive](https://www.tug.org/texlive/)
- make
- python 3.+
- packages and filters: [Pygments](https://pygments.org/download/), [pandoc-include](https://github.com/DCsunset/pandoc-include#installation), [texlive-xetex](https://tug.org/xetex/), texlive-latex-extra, lmodern, [librsvg2-bin](https://askubuntu.com/a/31446)
- symbola font

For this later, note that starting [with version 11](http://web.archive.org/web/20181228102842/http://users.teilar.gr/%7Eg1951d/Symbola.pdf), the licence is too restrictive for non-personal use.
As a consequence, users are asked to make sure they do not use a version greater than v.10.24, which is "free for any use" and [archived on-line](http://web.archive.org/web/20180307012615/http://users.teilar.gr/~g1951d/Symbola.zip) (curious users can also refer to [the related webpage](http://web.archive.org/web/20180307012615/http://users.teilar.gr/~g1951d/)).
Note that installing this dependency using a unix-like package manager will result in installing a version of the font that [is free to use in any context](https://metadata.ftp-master.debian.org/changelogs//main/t/ttf-ancient-fonts/ttf-ancient-fonts_2.60-1.1_copyright). 

You can make sure you are currently using the latest version of panflute by running
```
pip install -U panflute
```
This is needed if running a recent version of pandoc (as of pandoc 3.1.6.1 at least).

#### Running the build

After installing all dependencies, from the repository root, run:

```bash
make
```

make fetch <-- Document that

To see a list of other alternative build options run

```bash
make help
```

## Website

### Editing the website

The website <https://princomp.github.io/> is built from the `.md` files contained in the `content/` folder using [a dedicated branch](https://github.com/princomp/princomp.github.io/tree/quartz) of [quartz](https://quartz.jzhao.xyz/).
To edit the layout, style, or other features such as the footer, please

- Refer to quartz's [website](https://quartz.jzhao.xyz/), [repository](https://github.com/jackyzha0/quartz) and general community,
- Knowing that [multiple edits](https://github.com/princomp/princomp.github.io/commits/quartz/) already tweaked its style.

### Deploying locally the website

Start by [building the resource locally](#build-locally).


## How to edit the style?










## Repository Maintenance

This repository uses following tools and technologies:

- git - version control
- Github - to make source code available on the web
- markdown, LaTeX - for writing the resources
- pandoc - for converting documents to various output formats
- make - for specifying how to build this resource
- github actions - to automatically build the resource
- github pages - to serve the accompanying website
- additional packages for specific tasks: texlive, Pygments, pandoc filters, [lua filter](https://github.com/jgm/pandoc/issues/2104), etc.
- fonts-symbola - to produce the emoji and other symbols in the pdf document.
- [utteranc.es](https://utteranc.es/) - for feedback through website
- [csharpier](https://github.com/belav/csharpier) - to tidy the C## source code

### Build outputs

The resource material is organized into specific directories (cf. [resource organization](#resources-organization)). These resources are then compiled into templated documents in various formats using [pandoc](https://pandoc.org/MANUAL.html). Different directories undergo different build steps as defined in the project [Makefile](https://github.com/princomp/princomp.github.io/blob/main/Makefile) and generate various outputs. For example, lecture notes are compiled into a textbook and labs are packaged into individual labs. The makefile explains the exact steps applied to each type of resource.

### Github actions

This resource is built automatically every time changes are committed to the main branch of the repository. This is configured to run on [Github actions](https://github.com/features/actions). There are currently two configured [workflows](https://github.com/princomp/princomp.github.io/actions): one to build the resource and to deploy it, and a second one to check that any opened pull requests can be built successfully. 

The build configuration uses texlive to keep the dependency installation time low. Similarly, the choice of Python packages is preferable for pandoc filters, because they are usually straightforward and fast to install. We want to avoid choosing packages that significantly increase build time.

Currently Github actions offers unlimited free build minutes for public repositories (and 2000 min/mo. for _private_ repositories, should we ever need them), which hopefully continues in perpetuity (if it does not there are other alternative services). Going with one specific CI service over another is simply a matter of preference. 

Following a successful build, the build script will automatically deploy the generated resources to an accompanying website hosted on [github pages](https://pages.github.com/). In the repository a special branch `gh-pages` represents the contents of the deployed website. It also allows maintainers to observe the generated build outputs.

### Creating releases

Currently a github action is setup to do the following: whenever a new commit is made to the main branch, the action will build the resource and add the generated books as a pre-release under releases and tag them as "latest". If a subsequent commit occurs it will overwrite the previous latest files and become the new latest version. This cycle continues until maintainers are ready to make a versioned release (or "package").

Making a versioned release is done as follows:

#. Go to [repository releases](https://github.com/princomp/princomp.github.io/releases)
#. Choose latest, which contains the files of the latest build
#. Edit this release, giving it a semantic name and a version, such as v1.0.0. Name and version can be the same.
   (cf. [semantic versioning](https://semver.org/))
#. Enter release notes to explain what changed since last release
#. Uncheck "This is a pre-release"
#. Check "Set as the latest release"
#. Update release

Following these steps will generate a new, versioned release. The versioned releases will be manually uploaded to and archived on galileo.

Once this is done, remember to create the next pre-release:

#. Go to [the repository releases](https://github.com/princomp/princomp.github.io/releases).
#. Click on "Draft a new release".
#. Pick the tag "Latest".
#. Click on "Generate release notes"
#. Check "This is a pre-release"
#. Click on "Publish release"


### Maintaining repository feedback

Resource users can submit feedback about the resource through various means, one of which is leaving comments on the website. This feature is enabled by [utteranc.es](https://utteranc.es/). 

To manage user feedback over time, a semester-specific repository is created for issues only. This must be a public repository and located under the same organization as the resources repository. utteranc.es widget is configured to point to this repository. After a semester is over,  this feedback repository will be archived, and a new one created for the next semester. This will simultaneously archive all older issues and reset the feedback across website pages.

#### Migrating feedback repository

The steps for migrating feedback target repository are as follows:

#. Create a new **public** repository under `csci-1301` github organization. Follow the established naming convention, and leave all the options except for visibility (which needs to be set to public) by default.
#. Go to repository Issues (make sure issues is enabled in repository settings)
#. Create a new label whose _label name_ is `comment` (to match [widget configuration](https://github.com/princomp/princomp.github.io/blob/main/templates/web/template.html#L87-L94))
#. Go to [`Organization Settings > Installed GitHub Apps`](https://github.com/organizations/csci-1301/settings/installations) 
#. Choose "utterances" > "configure"
#. Under "Repository access" > "Only select repositories"
   - select the repository created in step 1. 
   - remove the previous semester feedback repository
#. Save
#. In `princomp.github.io` repository open `/templates/web/template.html`
#. Update utteranc.es widget code to point to the new feedback repository created in step 1.

    ```js
    <script data-external="1"
            src="https://utteranc.es/client.js"
            repo="csci-1301/{REPOSITORY_NAME}"
            label="comment" …>
    </script>
    ```

#. Commit change to template.html
#. Make sure the feedback works after migration. If it does not, retrace your steps.
#. Archive the earlier feedback repository in its settings.

### Maintaining Instructors / G/UCA rights

Every semester,

- [The members of the "UCAs" team](https://github.com/orgs/csci-1301/teams/ucas) should be updated,
- A "uca-resources-<semester>-YYYY" repository should be created, by [forking the template](https://github.com/princomp/uca-resources-template) (private repository),
- The new repository should be added to the [list of repositories of the team](https://github.com/orgs/csci-1301/teams/ucas/repositories) (as maintainer),
- The old repository should be deleted from that same list, and then archived.
- GRAs should be added / removed from the [instructors list](https://github.com/orgs/csci-1301/teams/instructors), and previous instructors should be removed from that same list,
- GRAs should be [added to the "UCAs" teams](https://github.com/orgs/csci-1301/teams/ucas/members) and given "maintainer" rights (_inside that team_, and not for the whole organization).


# TEMP NOTES


Possible improvements:

- Integrate callouts, as <https://quartz.jzhao.xyz/features/callouts>, <https://gist.github.com/jskherman/8e721302e67d308e8a81f3df84f01f20>, <https://www.reddit.com/r/LaTeX/comments/1baudg4/callouts_in_latex/>, <https://tex.stackexchange.com/questions/714908/newcommand-syntax-with-callouts>, <https://forum.obsidian.md/t/rendering-callouts-similarly-in-pandoc/40020/6>, <https://raw.githubusercontent.com/kdheepak/kdheepak.github.io/main/blog/pandoc-lua-filter-for-alerts/index.md>.

- Document [quartz](quartz.jzhao.xyz/), how to run it locally, and explain the edits made in <https://github.com/princomp/princomp.github.io/tree/quartz-migration>. 

- explain how order works, and that changing 
```
useSavedState: true, // To debug the explorer, change to "false" (this way, the menu is not cached / permanent), 
```
in https://github.com/princomp/princomp.github.io/blob/quartz/quartz/components/Explorer.tsx can help in debugging the changes.


- Add logos before code, pdf, odt, docx, md.

- explain how to add lecture (and how to sort it in the menu and get it in the book pdf, but also that it must have only one title element at top level).

- explain that no two files should have the same name considering the sorting we use ^

- give title to code snippets / code blocks

- sort out misc folder

```
[WARNING] Could not fetch resource ./../../img/solution_explorer_rectangle.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/create_project.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/select_net.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_1.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_2.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_3.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_4.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/create_project_monodevelop.png: replacing image with description
[WARNING] Could not fetch resource ./../../img/solution_explorer_rectangle.png: PandocResourceNotFound "./../../img/solution_explorer_rectangle.png"
[WARNING] Could not fetch resource ./../../img/create_project.png: PandocResourceNotFound "./../../img/create_project.png"
[WARNING] Could not fetch resource ./../../img/select_net.png: PandocResourceNotFound "./../../img/select_net.png"
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_1.png: PandocResourceNotFound "./../../img/create_project_on_mac_1.png"
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_2.png: PandocResourceNotFound "./../../img/create_project_on_mac_2.png"
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_3.png: PandocResourceNotFound "./../../img/create_project_on_mac_3.png"
[WARNING] Could not fetch resource ./../../img/create_project_on_mac_4.png: PandocResourceNotFound "./../../img/create_project_on_mac_4.png"
[WARNING] Could not fetch resource ./../../img/create_project_monodevelop.png: PandocResourceNotFound "./../../img/create_project_monodevelop.png"
```

```
[WARNING] Missing character: There is no  (U+FE0F) (U+FE0F) in font [templates/fonts/urw_gothic/U
[WARNING] Missing character: There is no  (U+FE0F) (U+FE0F) in font [templates/fonts/urw_gothic/U
```

```
[WARNING] Duplicate identifier 'general' at ./docs/academic_life/getting_help.md line 7 column 1
[WARNING] Duplicate identifier 'school' at ./docs/academic_life/getting_help.md line 18 column 1
[WARNING] Duplicate identifier 'install-win' at ./docs/programming_and_computer_usage/installing_software.md line 56 column 1
[WARNING] Duplicate identifier 'general' at ./docs/academic_life/getting_help.md line 7 column 1
[WARNING] Duplicate identifier 'school' at ./docs/academic_life/getting_help.md line 18 column 1
[WARNING] Duplicate identifier 'install-win' at ./docs/programming_and_computer_usage/installing_software.md line 56 column 1
[WARNING] Duplicate identifier 'general' at ./docs/academic_life/getting_help.md line 7 column 1
[WARNING] Duplicate identifier 'school' at ./docs/academic_life/getting_help.md line 18 column 1
[WARNING] Duplicate identifier 'install-win' at ./docs/programming_and_computer_usage/installing_software.md line 56 column 1
[WARNING] Duplicate identifier 'general' at ./docs/academic_life/getting_help.md line 7 column 1
[WARNING] Duplicate identifier 'school' at ./docs/academic_life/getting_help.md line 18 column 1
[WARNING] Duplicate identifier 'install-win' at ./docs/programming_and_computer_usage/installing_software.md line 56 column 1
[WARNING] Missing character: There is no  (U+FE0F) (U+FE0F) in font [templates/fonts/urw_gothic/U
[WARNING] Missing character: There is no  (U+FE0F) (U+FE0F) in font [templates/fonts/urw_gothic/U
``` 


Notes:

- Undo changes in explorer.tsx (csci-1310/quartz/quartz/components/Explorer.tsx)

```
useSavedState: false, // TEMPORARY, to debug the explorer.
```

## Website

- The favicon are in the quartz branch, at `quartz/static/`, and have been generated using <https://realfavicongenerator.net/>.

