---
tags:
- datatypes/collections
---

# List as ICollection

Another way of implementing lists is to make our class realize the [ICollection interface](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=net-9.0):


!include diag/cla/ICollection.md

This requires implementing a series of properties and methods:


```{download="./code/projects/CList_ICollection.zip"}
!include`snippetStart="/* Done with Cell.*/", snippetEnd="/* We are done realizing the ICollection class. */"` code/projects/CList_ICollection/CList_ICollection/CList.cs
```


