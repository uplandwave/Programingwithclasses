public class Reference{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public void DisplayRef(){
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }




    

    

}