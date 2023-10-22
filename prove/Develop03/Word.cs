using System.Reflection.Metadata.Ecma335;

public class Word{
    private string _word;
    private bool _hiddenstatus;
    public Word(string word){
        _word = word;
        _hiddenstatus = false;
    }
    public void DisplayWord_hidden(){
        //MOVE to scripture overall scripture display thing
        Random rando = new Random();
        int rando_index = rando.Next(0,2);
        if (rando_index == 1){
            _hiddenstatus = true;
        }if (_hiddenstatus == true){
            int length_amount = _word.Length;
            foreach (char tem_char in _word){
                Console.Write("_");
            }
        }else if (_hiddenstatus == false){
            Console.Write(_word);
        }Console.Write(" ");
    }
    public void DisplayWord(){
        Console.Write(_word);
        Console.Write(" ");
    }
}