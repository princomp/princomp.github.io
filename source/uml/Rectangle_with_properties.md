![A UML diagram for the Rectangle class ([text version](uml/uml/Rectangle_with_properties.txt))](data:image/png;base64,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  "class Rectangle{     + << property >> Width: int     + << property >> Length: int      + ComputeArea() int } ")