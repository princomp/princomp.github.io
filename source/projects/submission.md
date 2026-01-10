---
title: How to Submit Projects
---

This page assumes that you already created a project, following the instructions in the prompt if there are any.
Note that your instructor will make efforts to accommodate all versions of the .NET framework, the important is that your project can compile with *some* version of it.

# Submission

First, make sure your name and the date is placed in a delimited comment at the very beginning of each of your `.cs` file.

| ⚠ Warning       |
|:---------------------------|
| A *delimited* comment starts with `/*` and ends with `*/`. It must be *on the very first line* in your file, even before `using System;`. |

Once your project is done, [zip the folder](./docs/programming_and_computer_usage/unzipping_archives#zipping-files) into a file `lname_fname`, where `lname` is your last name and `fname` is your first name.
With the file extension, the filename will look like `lname_fname.zip`.

| ⚠ Warning       |
|:---------------------------|
| Make sure your file is named "lname_fname.zip" and not "lname_fname.zip.zip".  Some operating systems hide the file's extension by default, but you may be  able to see it by right-clicking on it and then selecting "Properties" or "Get Info". |

Upload this zip onto D2L / LMS before the deadline in the appropriate assignment submission folder.

| ⚠ Warning       |
|:---------------------------|
| Make sure you submitted the correct files, for instance by retracing the steps described in [the Hello World lab](./labs/HelloWorld#how-was-the-backup). |


## Criteria for Success

A good, finished project should include *all* of the following:

- Something was submitted on D2L.
- The archive can be downloaded and extracted, and the solution in it can be opened using any IDE.
- The archive and solution have the correct names (if specified).
- Your name and the date are in a delimited comment at the beginning of every `cs` file.
- The program compiles and can be executed.
- All the variables have appropriate types and are set to the correct value.
- Your code is commented.

## Advice and Recommendations

- Read the problem statement over and over; make sure you did not overlook anything.
- Make sure your project compiles without errors or warnings and can be executed as expected.
- Test your code again and again, and compare your result with our examples, if provided, or make up some.
- A partially completed project is better than nothing. Do not hesitate to add a comment describing your difficulties; that will show that you are aware of the limitations of your program.
- Make sure you submitted the correct files by re-downloading them (possibly on a different computer) and making sure you can still compile and execute your program.

## Elegance, Clarity and Readability

While elegance, clarity and readability are not *strictly speaking* parts of the rubric, they matter.
Try to

- Comment your code,
- Avoid `while(true)` loops (so that the reader can ["understand the termination condition just by looking at the header"](https://stackoverflow.com/a/390566)),
- Remove useless keywords (do you know what `internal` do? If not, consider removing it from your program),
- Not load namespaces that you are not using.

## Getting Help 

You can ask the instructor or the (under)graduate course assistants for help and feedback. Please upload your project according to the instructions and send an email asking to go over it if you want us to check that you submitted the correct file, that your code compiles, etc.
You should ask early and not wait until the last minute.

| ⚠ Warning       |
|:---------------------------|
| *Do not* ask other classmates for help, copy and paste from the internet, or ask a chatbot to write the program for you. This work is supposed to be *your own*, and should reflect *your own* understanding. Getting help from un-authorized sources will hurt your understanding of this class and therefore your grade on the long run. | 

How to share a project is also explained [in this video](./vid/CreateUploadProjectTutorial_light.mkv).

## Checklist

- [ ] Project compiles.
- [ ] Tested project with example in project description.
- [ ] Tested project with example(s) of your own.
- [ ] Check project requirements for anything missing.
- [ ] [Zip your project](./docs/programming_and_computer_usage/unzipping_archives#zipping-files).
- [ ] Rename it with the format *lastname_firstname* so the entire filename is *lastname_firstname.zip*.
- [ ] Test zip file by unzipping it and opening it to see if it loads correctly. If not, repeat previous step.
- [ ] Submit project to the corresponding zip folder on D2L.
