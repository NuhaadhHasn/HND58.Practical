# DSA: data structure exercises in Java (HND 58)

The Data Structures and Algorithms exercises from my 58th batch at ICBT Kandy. One Java class per exercise, in `DSA58/src`. Compile and run with any JDK (written and tested with JDK 20): `javac -d out DSA58/src/*.java`, then `java -cp out <ClassName>`.

| Class | What it does (output of a run) |
|---|---|
| `StackX` | a stack of numbers: push 20, 40, 60, 80, then pop them all (`80 60 40 20`) |
| `Queue` | a circular queue of size 5: insert 10 to 40, remove three, insert 50 to 80 (wrapping round), then remove and print everything (`40 50 60 70 80`) |
| `LinearSearchEx`, `binarySearchEx` | linear search (`Found`) and binary search in a sorted array (`Not Found` for the value 555) |
| `bubbleSortEx`, `SelectionSort`, `InsertionSort` | the three simple sorts, printing the array (`InsertionSort` prints it after every pass) |
| `Factorial` | factorial of 5 (`120`) |
| `test` | a scratch class: a small `add()` method (prints `11`); it did not compile as received (a static `main` used an instance field) and was fixed in its own commit |

My lecture notes, the exam and the same class exercises as a first set are in my private coursework repository.
