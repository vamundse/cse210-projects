/*
This library class was supposed to have a Dictionary of scriptures that the program could randomly pick from.
But I did not have enough time to finish it.
*/

class Library
{
    Dictionary<Reference, string> _scriptures = new Dictionary<Reference, string>();
    Random _randomNumber = new Random();
    private string _text = "";

    public Library()
    {
        Reference john316 = new Reference("John", 3, 16);
        _scriptures.Add(john316, "For God so loved the world, that he gave his only begotten Son, \n that whosoever believeth in him should not perish, but have everlasting life.");

        Reference DC933637 = new Reference("Doctrine and Covenants", 93, 36, 37);
        _scriptures.Add(DC933637, "The glory of God is intelligence, or, in other words, light and truth. \n Light and truth forsake that evil one.");
    }

    public void RandomScripturePick(int number = 1)
    {
        List<Reference> keys = new List<Reference>(_scriptures.Keys);
        for (int i = 0; i < number; i++)
        {
            int index = _randomNumber.Next(0, _scriptures.Count);
            Scripture randomScripture = new Scripture(keys[index], _scriptures[keys[index]]);
            /*Reference randomReference = keys[index];
            _text = _scriptures[randomReference];*/
        }
    }
}