public class Scripture{
    private List<Word> _words = new List<Word>();
    private List<Word> _tempwords = new List<Word>();
    public void AddWord(Word word){
        _words.Add(word);
    }
    public void Display_Scrip(){
        foreach (Word word in _words){
            word.DisplayWord();
        }
    }
    public void Display_Scrip_hidden(){
        foreach (Word word in _words){
            word.DisplayWord_hidden();
        }
    }
}