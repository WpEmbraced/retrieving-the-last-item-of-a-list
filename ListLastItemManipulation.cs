List<string> myList = new List<string> { "red", "blue", "green" };

// Get the last item using the Count property
string lastItem = myList[^1];

// Remove the last item from the list using RemoveAt
myList.RemoveAt(^1);

// Get the last item using LINQ LastOrDefault() method
lastItem = myList.LastOrDefault();
