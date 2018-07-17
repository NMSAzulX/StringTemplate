# StringTemplate
For the issue: https://github.com/dotnet/corefxlab/issues/2396

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
Frequency=2156251 Hz, Resolution=463.7679 ns, Timer=TSC
.NET Core SDK=2.1.202
  [Host] : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|         Method | count |      Mean |    Error |   StdDev |   Gen 0 | Allocated |
|--------------- |------ |----------:|---------:|---------:|--------:|----------:|
|  StringBuilder |  1000 |  81.57 us | 1.745 us | 3.147 us | 40.6494 |  187.5 KB |
|   StringFormat |  1000 | 159.37 us | 1.331 us | 1.245 us | 23.6816 | 109.38 KB |
| TemplateFormat |  1000 |  59.30 us | 1.150 us | 1.020 us | 18.6157 |  85.94 KB |
