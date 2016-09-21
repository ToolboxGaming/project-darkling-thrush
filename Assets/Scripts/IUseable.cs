using UnityEngine;

public interface IUseable {
	// Do the thing
	void use(GameObject player);

	// Put up a menu that can enable more complicated usages
	void useMenu(GameObject player, GameObject UI);

	// The text to display when an object can be used
	string actionText {get;}
}
