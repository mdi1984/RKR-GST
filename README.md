# Running Karp-Rabin GST
A C# implementation of the Running Karp-Rabin Greedy String Tiling Algorithm

### Algorithm
[http://sydney.edu.au/engineering/it/research/tr/tr463.pdf](http://sydney.edu.au/engineering/it/research/tr/tr463.pdf)

### Usage
```cs
  var submissionA = new SimpleSubmission<char>(new char[] { 'a', 'd', 'o', 'r', 'u', 'n', 'r', 'u', 'n' });
  var submissionB = new SimpleSubmission<char>(new char[] { 'r', 'u', 'n', 'a', 'd', 'o', 'r', 'u', 'n' });
  
  var comparator = new Comparator<char>(6, submissionA, submissionB); // 6 = mimum match length
  var result = comparator.Compare();
```