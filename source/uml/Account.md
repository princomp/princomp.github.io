![A UML diagram for the Account class ([text version](./uml/Account.txt))](data:image/png;base64,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  "class Account{     -balance : decimal     +GetBalance() decimal     +DisplayBalance() void     +AddFunds(amount:decimal) void     +Withdraw(amount:decimal) void  } ")