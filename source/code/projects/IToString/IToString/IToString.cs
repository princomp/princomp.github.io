/* 
 *  The question of adding ToString methods to interface is a bit delicate and will certainly not be on any CSCI 1302 exam. The answer is, in short: you cannot force the implementation of a ToString with an interface.
 * This is discussed at length at                                                                                                                                                                       
 * https://stackoverflow.com/q/510341
 * where an alternative solution is provided (essentially: use an abstract class).
 *
 * Observe that this would compile just fine, even if Demo does not provide the implementation of a ToString method. Of course, Demo already posses a ToString method, the one every class inherits. 
 */

interface IToString
{
  string ToString();
}
