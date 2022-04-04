using NewRelic;

// Note: args is the default console parameter name inbuilt in .Net
if (args.Length > 0)
{
    foreach (var arg in args)
    {
        var fileName = Path.Combine(Directory.GetCurrentDirectory(), arg);
        if (File.Exists(fileName))
        {
            Find find = new Find();
            var top100 = find.FindMostCommonSequences(fileName, 100);
            if (top100 != null)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Top 100 Word Sequence for " + fileName);
                foreach (var seq in top100)
                    Console.WriteLine(seq);
            }
        }
        else
        {
            Console.WriteLine("You must enter valid available FileName");
        }
    }
}
else
{
    Console.WriteLine("Please provide one or more file names");
}
