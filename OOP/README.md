# OOP: Java class exercises (HND 58)

The Java practicals from my 58th batch at ICBT Kandy, as plain source folders (`src/`, one folder per exercise). They compile with any JDK (written and tested with JDK 20): from a folder, `javac -d out $(find . -name "*.java")` then `java -cp out <MainClass>`. Several read from the keyboard.

| Folder | What it is | Main class(es) |
|---|---|---|
| `MyFirstProgram` | first Java steps: variables, operators, `if`/`switch`, loops, `Scanner`, `Math`, random numbers, a small Swing window | one class per topic in `com.myfirstprogram` |
| `OOP_Class_5` | classes and inheritance: an abstract `Students` with local, international and part-time students, an `Employee` app, object and array exercises, a queue written by hand | `studentPackage.Main`, `empApp.Main`, `ObjEx.Main`, `testProgram.*`, `testForStudent1.Main` |
| `Scenario1`, `Scenario2` | two scenario exercises of a dental clinic: a scan machine with its details, and employees (director, dentists) with department and salary | `Main` |
| `Composite` | the Composite design pattern: small and big pieces of advice that print as one list | `Main` |
| `Observer` | the Observer design pattern: newspapers (BBC, Newsday) notify their readers | `Main` |
| `Singleton`, `Singleton_java` | the Singleton design pattern: a second request for the "Principle" object says it already exists; `Singleton_java` is a smaller, earlier start of the same exercise (its `Main` only prints Hello world) | `Main` |
| `DSA58` | data structures: stack, queue, linear and binary search, bubble, selection and insertion sort, factorial | one class per exercise |

All of them were compiled and run. The queue demo and the `test` class in `DSA58` did not compile as received; see the second commit for what was changed.

## Changed before publishing

- A friend's name used as sample data is replaced by a made-up one (`Nimali Perera`), the package `testForTania1` is renamed `testForStudent1`, and the 12-digit ID number used as sample data in `OOP_Class_5/studentPackage/Main.java` is replaced by `200000000000`.
- IDE files (`.idea`, `.iml`, compiled `out/` folders) are not kept.
