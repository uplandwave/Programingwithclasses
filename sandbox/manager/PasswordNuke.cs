public class PasswordNuke{

//new List<Users

    public PasswordNuke(){
        
    }

    public void TheBigOne(){
        string filename = "parker.txt";
        StreamWriter new_stream2 = new StreamWriter(filename);
        new_stream2.Close();
        filename = "jacob.txt";
        StreamWriter new_stream3 = new StreamWriter(filename);
        new_stream3.Close();
        filename = "user.txt";
        StreamWriter new_stream = new StreamWriter(filename);
        new_stream.Close();

    }

    public void NukeDisplay(){
        ExpVisualizer();
        ExpVisualizer();
        ExpVisualizer();
        ExpVisualizer();
        Console.Clear();
    }

    public void ExpVisualizer(){
        NukeImg1();
        Thread.Sleep(300);
        NukeImg2();
        Thread.Sleep(300);
        NukeImg3();
        Thread.Sleep(300);
    }
    
    

// external file method, dot o file, shared library compiler
// via moloch

    public void LaunchSequence(){
        Console.WriteLine("======LAUNCH SEQUENCE INITAITED======");
        //Console.WriteLine();
        Console.Write("5 ");
        LaunchSequence_Reducer();
        Console.Write("4 ");
        LaunchSequence_Reducer();
        Console.Write("3 ");
        LaunchSequence_Reducer();
        Console.Write("2 ");
        LaunchSequence_Reducer();
        Console.Write("1 ");
        LaunchSequence_Reducer();
        Console.Write("0 ");
        
        
    }

    public void LaunchSequence_Reducer(){
        spin();
        Console.Write("\b \b");
        // spin();
        // Console.Write("\b \b");
    }

   

    public void spin(){
        string a = "\u2623";
        Console.Write("|");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write(a);
        // FREAKING UNICODE DOESN'T WORK YOU PIECE OF CRAP
        Thread.Sleep(100);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(100);
    }

    public void NukeImg1(){
        Console.Clear();
        Console.WriteLine("                   _____________      ");
        Console.WriteLine("               ___|             |___");
        Console.WriteLine("           ___|     __      _       |___");
        Console.WriteLine("          |      |        _             |    +");
        Console.WriteLine("     +   |      |   __           __      |");
        Console.WriteLine("         |                               |");
        Console.WriteLine("        _|   |  /                  |     |_");
        Console.WriteLine("  ++   |      |                            |  +");
        Console.WriteLine("       |_                            |    |");
        Console.WriteLine("         |  |     [              _    |  _|");
        Console.WriteLine("         |_                             _|");
        Console.WriteLine("           |_  |  _               |   _|");
        Console.WriteLine("             |_    |                _|     +");
        Console.WriteLine("          +    |_             |    | ");
        Console.WriteLine("                 |  |              |");
        Console.WriteLine("              +   |_             _|    +");
        Console.WriteLine("        +           | |       | |");
        Console.WriteLine("                +   |           |");
        Console.WriteLine("                    | |       / |           +");
        Console.WriteLine("          +      ___|           |___");
        Console.WriteLine("            ____|  __  |     |  __  |______");
        Console.WriteLine("           |      |               |        |");
    }

    public void NukeImg2(){
        Console.Clear();
        Console.WriteLine("                   _____________      ");
        Console.WriteLine("               ___|       _     |___");
        Console.WriteLine("           ___|     __      _       |___");
        Console.WriteLine("          |      |        _             |    #");
        Console.WriteLine("     #   |      |   __           __      |");
        Console.WriteLine("         |                               |");
        Console.WriteLine("        _|   |  /   |       |      |     |_");
        Console.WriteLine("  ##   |      |                            |  #");
        Console.WriteLine("       |_                     |      |    |");
        Console.WriteLine("         |  |     [              _    |  _|");
        Console.WriteLine("         |_                             _|");
        Console.WriteLine("           |_  |  _         _     |   _|");
        Console.WriteLine("     #       |_    |                _|     #");
        Console.WriteLine("          #    |_        |    |    | ");
        Console.WriteLine("                 |  |              |");
        Console.WriteLine("              #   |_             _|    #");
        Console.WriteLine("        #           | |       | |");
        Console.WriteLine("                #   |           |");
        Console.WriteLine("                    | |       / |           #");
        Console.WriteLine("          #      ___|           |___");
        Console.WriteLine("            ____|  __  |     |  __  |______");
        Console.WriteLine("           |      |               |        |");
    }

    public void NukeImg3(){
        Console.Clear();
        Console.WriteLine("                   _____________      ");
        Console.WriteLine("               ___|       _     |___");
        Console.WriteLine("           ___|     __      _       |___");
        Console.WriteLine("          |      |        _  |    _     |    #");
        Console.WriteLine("     {}  |      |   __           __      |");
        Console.WriteLine("         |             *                 |");
        Console.WriteLine("        _|   |  /   |       |      |     |_");
        Console.WriteLine("  ##   |      |                  !         |  #");
        Console.WriteLine("       |_           //        |      |    |");
        Console.WriteLine("         |  |     [     |        _    |  _|");
        Console.WriteLine("   $     |_         ^    $              _|");
        Console.WriteLine("           |_  |  _         _     |   _|");
        Console.WriteLine("     #       |_    |                _|     #");
        Console.WriteLine("          ?    |_        |    |    | ");
        Console.WriteLine("                 |  |              |");
        Console.WriteLine("              $   |_             _|    !");
        Console.WriteLine("        #           | |  L    | |");
        Console.WriteLine("          <     #   |           |");
        Console.WriteLine("                    | |  >    / |           #");
        Console.WriteLine("          #      ___|           |___");
        Console.WriteLine("            ____|  __  |     |  __  |______");
        Console.WriteLine("           |      |               |        |");
    }
    }