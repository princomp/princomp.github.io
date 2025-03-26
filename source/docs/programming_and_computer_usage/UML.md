# UML Diagrams

## Attributes and Properties
| Type of Attribute or Property | UML Formatting |
| :---: | :---: |
| Public attribute | `public attribute : [data type]` |
| Private attribute | `private attribute : [data type]` |
| Public property | `public <<property>> Property : [data type]` |
| Private property | `private <<property>> Property : [data type]` |

## Methods with Return Type
| Type of Method | UML Formatting |
| :---: | :---: |
| Public method with no arguments | `public Method() : [return type]` |
| Private method with no arguments | `private Method() : [return type]` |
| Public method with arguments | `public Method(argument1 : [data type], argument2 : [data type]) : [return type]` |
| Private method with arguments | `private Method(argument1 : [data type], argument2 : [data type]) : [return type]` |

## Methods with Void or No Return Type
| Type of Method | UML Formatting |
| :---: | :---: |
| Public method with arguments | `public Method(argument1 : [data type], argument2 : [data type])` |
| Private method with arguments | `private Method(argument1 : [data type], argument2 : [data type])` |

## Special Cases
| Case | How to Change UML Formatting |
| :---: | :---: |
| Static | Underline |
| Abstract | Italicize |
| Protected | `#` instead of `public` or `private` |
| Abstract class | Add `<<Abstract>>` above class name |
| Interface | Add `<<Interface>>` above class name |

## Arrows
| Arrow Type | What It Means |
| :---: | :---: |
| Open arrow with solid line | Inheritance |
| Open arrow with dashed line | Realization |
