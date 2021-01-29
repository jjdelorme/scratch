// inspiration: https://jpetazzo.github.io/2020/02/01/quest-minimal-docker-images-part-1/
// can you build a minimalist .NET Core app with "FROM scratch" in Dockerfile (not alpine)
// probably possible if you read this: https://github.com/dotnet/core/blob/master/Documentation/self-contained-linux-apps.md
// not sure it's really worth it, my hello world is 21mb, Alpine is only ~10mb.. 
using System;

namespace scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
