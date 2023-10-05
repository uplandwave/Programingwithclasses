using System;

class Journal {
    public List<Text> _entries = new List<Text>();
    DateTime _datetime = DateTime.Now;

    //this should put pull the promped and response into temporary memory.
    public void AddEntry(string prompt, string response) {
        Text text = new Text();
        text._timestamp = _datetime;
        text._prompt = prompt;
        text._content = response;
        _entries.Add(text);
    }
        public void DisplayJournal()
    {
        foreach (Text text in _entries)
        {
            Console.WriteLine();
            Console.WriteLine("Date: " + text._timestamp);
            Console.WriteLine("Prompt: " + text._prompt);
            Console.WriteLine("Response: " + text._content);
            Console.WriteLine();
        }
    }
    
    public void Save(string filename)
    {
        StreamWriter writer = new StreamWriter(filename);
        foreach (Text text in _entries)
        {
            writer.WriteLine(text._prompt);
            writer.WriteLine(text._content);
            writer.WriteLine(text._timestamp);
        }
        writer.Close();
    }

    public void Load(string filename)
    {
        _entries.Clear();
        StreamReader reader = new StreamReader(filename);
        while (!reader.EndOfStream)
        {
            string prompt = reader.ReadLine();
            string response = reader.ReadLine();
            string date = reader.ReadLine();
            var timestamp = DateTime.Parse(date);

            Text text = new Text();
            text._prompt = prompt;
            text._content = response;
            text._timestamp = timestamp;
            _entries.Add(text);

    }
    
    }};