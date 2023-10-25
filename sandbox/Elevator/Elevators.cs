public class Elevators{
    protected _floor
    protected _wantedFloor

    public Elevators(string floor, string wantedFloor){
        _floor = floor
        _wantedFloor = wantedFloor
    }
    public async void callElevator(){
        Console.WriteLine("Calling your elevator now...");
        await Task.Delay(5000);
        Console.WriteLine("Your elevator is here and the doors are open.");
        
    }
    public void closeDoors() {
        Console.WriteLine("The doors are  now closed. Which floor do you want to go: ");
        _wantedFloor = int.Parse(Console.ReadLine());
    }
    public void openDoors(){
        Console.WriteLine($"Welcome to floor {_floor}");
    }
}