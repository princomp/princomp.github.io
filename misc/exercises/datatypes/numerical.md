---
tags:
  - datatypes/numerical
aliases:
  - Datatypes - Numerical
---

## Warm-up Exercises



## Questions

#. Comment briefly on the type decimal and format C it can be used with in a C# code.
  <details><summary>Solution</summary>
  The decimal type is the most precise of the numeric types, and it can be used with the C format specifier to display values representing amounts of currency.
  </details>

#. What can you learn from this UML class diagram?
  
|     | Account                         |
| --- | ------------------------------- |
|     | - name : string                 |
|     |                                 |
|     | + SetName(accountName : string) |
|     | + GetName() : string            |
  <details><summary>Solution</summary>
    This diagram shows a class called "Account", which contains a private variable of type string called "name" and two public methods. The method called "SetName" has a void return type and has a parameter of type string called "accountName". The method called "GetName" returns a string value and has no parameters.
  </details>

#. Can conversion between two number types change value of a number?
Provide an example case.
<details><summary>Solution</summary>
  Yes, in the case of floats being converted into integers, the value must be truncated. For example, the value 4.876f, when converted into a integer, will become 4.
</details>
## Problems
