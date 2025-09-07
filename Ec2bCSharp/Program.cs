using System;
using System.IO;

namespace Ec2bKeyDeriver;

internal static class Program
{
	static void Main(string[] args)
	{
		if (args.Length < 1)
		{
			Console.WriteLine("Usage: Ec2bKeyDeriver <ec2b.bin> [out.bin]");
			return;
		}

		var ec2b = File.ReadAllBytes(args[0]);
		var xorpad = Ec2b.Derive(ec2b); // 4096 bytes

		var outPath = args.Length > 1 ? args[1] : "derived.bin";
		File.WriteAllBytes(outPath, xorpad);

		Console.WriteLine($"Derived xorpad: {xorpad.Length} bytes -> {outPath}");
	}
}
