|============================================================================|
|                                    Item                                    |
|----------------------------------------------------------------------------|
| - price: decimal                                                           |
| - description: string                                                      |
| - taxable: bool                                                            |
| + SALES_TAX: decimal                                                       |
|----------------------------------------------------------------------------|
| + Item(initDescription: string, initPrice: decimal, isTaxable: bool)       |
| + SetPrice(priceParameter: decimal)                                        |
| + GetPrice(): decimal                                                      |
| + SetDescription(descriptionParameter: string)                             |
| + GetDescription(): string                                                 |
| + SetTaxable(taxableParam: bool)                                           |
| + IsTaxable() : bool                                                       |
|============================================================================|
