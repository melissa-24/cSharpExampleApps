// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// DATA TYPES

string aString = "Yup I am a string";
int aInteger = 24;
bool aBoolean = true;
char aCharacter = 'm';

// PRINTING - THE DIFFERENT WAYS

// The basic version
Console.WriteLine("I am a basic Console.WriteLine");

// Using declared data from above 
Console.WriteLine(aString);

// Using more than 1 of the data types from above and or adding comments
Console.WriteLine($"Yes it is {aBoolean}, I am called string interpolation");

Console.WriteLine("This is the old way we had to combine things called concatenation with the integer: " + aInteger);

Console.WriteLine("This is another way but can be dedious to print a string '{0}', and a character '{1}'", aString, aCharacter);

// ARRAY / LIST / DICTIONARY

// Arrays can be created 2 ways empty or prefilled either way they will always have a set length.  You can change the values or add the values but never more than it's pre-determined length from creation
string[] myEmptyArray = new string[2];
Console.WriteLine("above is an empty array");
myEmptyArray[0] = "I can be added";
myEmptyArray[1] = "And so can I";
// myEmptyArray[2] = "But if uncommented I will create errors";
Console.WriteLine("myEmptyArray now has values added");

string[] myFilledArray = {"This Array", "already has", "content", "but still a set length"};
Console.WriteLine("myFilledArray has a set length but came with content already");
Console.WriteLine($"This is how I can print 1 item from my array {myFilledArray[0]}");
Console.WriteLine($"Since I added values to the empty array I can also print 1 item from that list as well like this {myEmptyArray[1]}");

// Lists are mutable.  These have no set length and content is added using .Add
List<string> myNewList = new List<string>();
myNewList.Add("I am being added to the list");
myNewList.Add("So am I");
myNewList.Add("since the list has no set size");
myNewList.Add("I can .Add things to it all day long");
myNewList.Add("but I won't");
Console.WriteLine("above is my list with content added");
Console.WriteLine($"Just like the array I an print 1 item like this {myNewList[4]}");

// Dictionaries are also mutable.  They also have no set length and content is added using .Add however they consist of Key/Value pairs

Dictionary<string, string> myDictionary = new Dictionary<string, string>();
myDictionary.Add("imAKey", "Im a value");
myDictionary.Add("weCanAdd", "things all day long");
myDictionary.Add("weAreCalled", "in similar but different ways");
myDictionary.Add("fromLists", "and Arrays");
Console.WriteLine($"I can print 1 item too but I look different {myDictionary["imAKey"]}");

// Loops - for and foreach

// for loops have specific conditions that must be declared
for(int i = 0; i < myEmptyArray.Length; i++) {
    Console.WriteLine("I will print once for every entry in the array");
}
for(int i = 0; i < myFilledArray.Length; i++) {
    Console.WriteLine($"I is currently {i} and the value in the array at that index is {myFilledArray[i]}");
}

// foreach loops have similar conditions but are sometimes easier to follow
int count = 0;
foreach(var item in myNewList) {
    Console.WriteLine("Item is 1 entry in the myNewList");
    Console.WriteLine($"{item} is at index {count} of the List");
    count++;
}
foreach(var item in myDictionary) {
    Console.WriteLine($"This is one way to print the keys and values from a dictionary. I am the key: {item.Key}, and I am the value: {item.Value}");
}
foreach(KeyValuePair<string, string> item in myDictionary) {
    Console.WriteLine($"I am the other way you can print items from a dictionary and is better with mixed data types. I am the Key: {item.Key} and like before I am the Value: {item.Value}");
}

// while loops - these require an extra step.  you need to give it something that will change in the loop to allow the loop to stop
// conditionals

int round = 0;
while(aBoolean) {
    Console.WriteLine($"While aBoolean is equal to {aBoolean} I will keep printing");
    if(round <= 4) {
        Console.WriteLine("As long as round's value is less than or not equal to 4 this if statement will run and increase teh round value");
        round++;
    } else {
        Console.WriteLine("Once it is equal to 4 the else will be triggered and print this statement and then change aBoolean to false, thus ending the while loop");
        aBoolean = false;
    }

}