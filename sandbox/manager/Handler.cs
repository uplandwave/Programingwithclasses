class Handler : BaseApp{
    
    public Handler(UserManager userManager) : base(userManager){
    }


    public override void mainMenu(){
    } 


    public void Save(){
        StreamWriter new_stream = new StreamWriter($"{currentUser}.txt");
        foreach (var password1 in passwords){
            new_stream.WriteLine(password1);
        }
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
