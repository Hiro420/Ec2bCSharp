# Ec2bCSharp
C# fork of Mero's ec2b.py

Installing
----------

```sh
    git clone https://github.com/Hiro420/Ec2bCSharp
    cd Ec2bCSharp
    dotnet build
```

Example
-------

```csharp
    var ec2b = File.ReadAllBytes(args[0]);
    var xorpad = Ec2b.Derive(ec2b);
    var outPath = args.Length > 1 ? args[1] : "derived.bin";
    File.WriteAllBytes(outPath, xorpad);
```

Links
-----
- [Original Hotaru's C/C++ code](https://github.com/HotaruYS/Ec2b)
- [Original Mero's ec2b.py code](https://github.com/GrownNed/ec2b.py)

## License and Attribution

All rights belong to **Mero** and **Hotaru**.\
This project is a fork and is not the original work.\
The applicable license for this repository is the same as in the original Mero project.
