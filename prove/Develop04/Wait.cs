public class Wait{
    public async void Pause(int _time){
        await Task.Delay(_time);
        Console.WriteLine();
    }
}