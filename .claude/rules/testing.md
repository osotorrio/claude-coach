# Testing rules

## Framework
- xUnit for all tests; no MSTest or NUnit.
- FakeItEasy for fakes, stubs, and mocks — no Moq, NSubstitute, or manual test doubles.

## Structure — AAA
Every test must follow Arrange / Act / Assert with a blank line between each section:
```csharp
// Arrange
var fake = A.Fake<IService>();
A.CallTo(() => fake.Get(1)).Returns("value");

// Act
var result = sut.DoSomething(1);

// Assert
Assert.Equal("expected", result);
```

## Naming
- Test method: `MethodName_Scenario_ExpectedBehavior` (e.g. `Calculate_NegativeInput_ThrowsArgumentException`).
- Test class: `{SubjectClass}Tests`.
- No abbreviations in test names — clarity over brevity.

## FakeItEasy conventions
- Use `A.Fake<T>()` — never `new` a concrete dependency in a test.
- Verify calls with `A.CallTo(...).MustHaveHappenedOnceExactly()` — avoid loose `MustHaveHappened`.
- Avoid faking value types or sealed classes; redesign the abstraction instead.

## Constraints
- No I/O (disk, network, DB) in unit tests — fake the boundary, test the logic.
- One logical assertion per test (multiple `Assert` lines are fine if they verify one concept).
- No `Thread.Sleep` or `Task.Delay` in tests.
