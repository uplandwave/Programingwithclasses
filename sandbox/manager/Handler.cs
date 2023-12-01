class Handler : BaseApp{
    List<Text> local_passwords;
    User currentuser;
    string line;
    public Handler(UserManager userManager, List<Text> _local_passwords, User _currentuser) : base(userManager){
        local_passwords = _local_passwords;
        currentuser = _currentuser;
    }
    

    public override void mainMenu(){
    } 


    public void Save(){
        Console.WriteLine(currentuser);
        string filename = $"{currentuser}.txt";
        StreamWriter new_stream = new StreamWriter(filename);
        //StreamWriter writer = new StreamWriter("test.txt");
        foreach (Text password in local_passwords){
            line = password._password;
            new_stream.WriteLine(line);
            line = password._site;
            new_stream.WriteLine(line);
        }
        new_stream.Close();
        
    }

    public void Load(){
        StreamReader new_reader = new StreamReader($"{currentUser}.txt");
        while (!new_reader.EndOfStream)
        {
            string password = new_reader.ReadLine();
            string site = new_reader.ReadLine();    
            Text text = new Text(password, site);
            //text._password = password;
            //text._site = site;
            passwords.Add(text);
        }
    }
}
