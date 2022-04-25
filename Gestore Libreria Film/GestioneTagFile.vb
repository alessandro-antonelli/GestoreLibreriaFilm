Module GestioneTagFile

    Sub lol()
        '============ Read/write metadata from a video ============
        Dim tfile = TagLib.File.Create("C:\My video.avi")
        Dim title As String = tfile.Tag.Title
        Dim duration As TimeSpan = tfile.Properties.Duration
        Console.WriteLine("Title: {0}, duration: {1}", title, duration)

        'change title in the file
        tfile.Tag.Title = "my new title"
        tfile.Save()

        '============ Read/write metadata from a Audio file ============
        'var tfile = TagLib.File.Create(@"C:\My audio.mp3");
        'string title = tfile.Tag.Title;
        'TimeSpan duration = tfile.Properties.Duration;
        'Console.WriteLine("Title: {0}, duration: {1}", title, duration);

        '// change title in the file
        'tfile.Tag.Title = "my new title";
        'tfile.Save();

        '============ Read/write metadata from an Image ============
        'var tfile = TagLib.File.Create(@"C:\My picture.jpg");
        'string title = tfile.Tag.Title;
        'var tag =  tfile.Tag as TagLib.Image.CombinedImageTag;
        'DateTime? snapshot = tag.DateTime;
        'Console.WriteLine("Title: {0}, snapshot taken on {1}", title, snapshot);

        '// change title in the file
        'tfile.Tag.Title = "my new title";
        'tfile.Save();

        '============ Read/write custom tags from a specific format ============
        'var tfile = TagLib.File.Create(@"C:\My song.flac");
        'var custom = (TagLib.Ogg.XiphComment) tfile.GetTag(TagLib.TagTypes.Xiph);

        '// Read
        'string [] myfields = custom.GetField("MY_TAG");
        'Console.WriteLine("First MY_TAG entry: {0}", myfields[0]);

        '// Write
        'custom.SetField("MY_TAG", new string[] { "value1", "value2" });
        'custom.RemoveField("OTHER_FIELD");
        'rgFile.Save();
    End Sub
End Module
