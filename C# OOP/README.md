## 🔑 1. Access Modifiers Table

| Modifier               | Access Scope                                             | Typical Use                               |
| ---------------------- | -------------------------------------------------------- | ----------------------------------------- |
| **private**            | Only the same **class**                                  | Internal fields, helper methods           |
| **public**             | Anywhere, any assembly/project                           | APIs, properties, methods                 |
| **internal**           | Same **assembly/project**                                | Library helpers, project-internal classes |
| **protected**          | Same class **and derived classes**                       | Base class members for inheritance        |
| **protected internal** | Same assembly **or derived classes in other assemblies** | Hybrid scenarios                          |
| **private protected**  | Same assembly **and derived classes**                    | Fine-grained inheritance control          |

---

## 🖼️ 2. Access Diagram with Arrows

```
          ┌─────────────────────────────┐
          │          Class A            │
          ├─────────────────────────────┤
          │ private        ◀ only here  │
          │ protected      ◀ here + subclasses │
          │ internal       ◀ anywhere in assembly │
          │ protected int. ◀ subclasses OR assembly │
          │ public         ◀ anywhere          │
          └─────────────────────────────┘

Outside Class A:
- private        ❌ cannot access
- protected      ❌ cannot access
- internal       ✅ if in same project/assembly
- protected int. ✅ if in same project OR subclass
- public         ✅ anywhere
```

---

## 🔹 3. Visualizing Multiple Files/Classes in a Project

```
Project/Assembly "MyProject"
┌───────────────┐          ┌───────────────┐
│ Car.cs        │          │ Engine.cs     │
│ internal class │          │ public class │
│ InternalHelper │◀ accessible inside project │
│ public Color   │◀ accessible anywhere        │
└───────────────┘          └───────────────┘
```

- `internal` members → visible **inside project**, hidden outside
- `public` members → visible **anywhere**
- `private` → only inside the **class**
- `protected` → visible to **subclasses**

---

## 🔹 4. Example with All Modifiers

```csharp
namespace MyProject
{
    internal class InternalHelper
    {
        public void Help() => Console.WriteLine("Project internal use");
    }

    public class Car
    {
        private string engine = "V8";       // only Car
        internal string model = "Sedan";   // same project
        public string Color { get; set; }  // accessible anywhere
        protected int speed = 100;         // subclasses
        protected internal int wheels = 4; // subclasses OR same project
        private protected string vin = "123"; // subclasses in same project
    }

    public class SportsCar : Car
    {
        public void ShowSpeed()
        {
            Console.WriteLine(speed);    // ✅ protected
            Console.WriteLine(wheels);   // ✅ protected internal
            // Console.WriteLine(vin);   // ✅ private protected (allowed in same project)
        }
    }
}
```

---

## 🔑 5. Quick Rules / Memory Tips

- **private** → "my secret" 🔒
- **public** → "open to everyone" 🌍
- **internal** → "friends in my project" 🏢
- **protected** → "family / subclasses" 👪
- **protected internal** → "project friends + family outside" 🏢👪
- **private protected** → "family only inside project" 👪🏢

---
