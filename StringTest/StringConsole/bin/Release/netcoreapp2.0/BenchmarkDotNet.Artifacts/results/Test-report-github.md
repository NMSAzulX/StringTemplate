``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
Frequency=2156251 Hz, Resolution=463.7679 ns, Timer=TSC
.NET Core SDK=2.1.202
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT


```
|         Method |       Mean |     Error |    StdDev |
|--------------- |-----------:|----------:|----------:|
|  StringBuilder |   902.3 us | 16.890 us | 15.799 us |
|   StringFormat | 1,587.0 us |  9.254 us |  7.727 us |
| TemplateFormat |   617.1 us | 11.141 us | 10.421 us |
