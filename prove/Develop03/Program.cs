Console.Clear();
Console.WriteLine();

//Asking the user for a new reference they would like to start studying
Console.Write("Enter the Book (e.g., D&C): ");
string referenceBook = Console.ReadLine() ?? string.Empty;

Console.Write("Enter the Chapter (e.g., 66): ");
string referenceChapter = Console.ReadLine() ?? string.Empty;
int intChapter;
int.TryParse(referenceChapter, out intChapter);

Console.Write("Enter the verse (e.g., 6): ");
string referenceVerse = Console.ReadLine() ?? string.Empty;
int intVerse;
int.TryParse(referenceVerse, out intVerse);

// Create a Reference object based on user input
Reference r = new Reference(referenceBook, intChapter, intVerse);

// Prompt the user for the text
Console.Write("Enter the scripture text: ");
string text = Console.ReadLine() ?? string.Empty;

Scripture scrip_retardation = new Scripture();
List<string> splitUp = text.Split(" ").ToList();
foreach (var item in splitUp){
    Word word = new Word(item);
    scrip_retardation.AddWord(word);
}

// This is the formatting for how the body will be
Console.WriteLine();
Console.Write("Your scripture is: ");
r.DisplayRef();
scrip_retardation.Display_Scrip();
Console.WriteLine();
Console.WriteLine("\nHit the ENTER key to REMOVE words, or CTRL + C to quit");
Console.WriteLine(); 

bool sym_status = true;

while (sym_status == true){
    string user_input = Console.ReadLine() ?? string.Empty;
    if (user_input == ""){
        Console.Clear();
        r.DisplayRef();
        scrip_retardation.Display_Scrip_hidden();
        Console.WriteLine("\n\nType any charterer then press ENTER or CTRL + C to quit.");
    } else {
        sym_status = false;
    }
}




