# Design patterns rules (Gang of Four)

## General
- Apply GoF patterns by intent, not by name — solve the problem first, name the pattern second.
- Prefer composition over inheritance (GoF principle); avoid deep class hierarchies.
- Program to interfaces, not implementations.

## Creational
- **Factory Method** — use when object creation logic should be deferred to a subclass or determined at runtime.
- **Abstract Factory** — use when creating families of related objects that must stay consistent.
- **Builder** — use for objects with many optional parameters; prefer over telescoping constructors.
- **Singleton** — avoid in application code; use DI container lifetime management instead.
- **Prototype** — use `ICloneable` or copy constructors; prefer records with `with` expressions in C#.

## Structural
- **Adapter** — wrap third-party or legacy types behind a project-owned interface.
- **Decorator** — add behaviour by wrapping, not by subclassing; chain decorators via constructor injection.
- **Facade** — expose a simplified interface over a complex subsystem; keep the facade thin.
- **Composite** — model part-whole hierarchies; use when callers treat leaves and composites uniformly.
- **Proxy** — use for lazy loading, access control, or logging; prefer over modifying the real class.

## Behavioural
- **Strategy** — inject behaviour as an interface; swap implementations via DI.
- **Observer** — prefer C# `event`/`IObservable<T>` over manual observer lists.
- **Command** — encapsulate requests as objects; useful for undo, queuing, and CLI dispatch.
- **Chain of Responsibility** — use middleware-style pipelines (e.g. MediatR behaviours) rather than manual chaining.
- **Template Method** — define the skeleton in a base class; prefer default interface methods in C# 8+ over abstract classes when possible.
- **Iterator** — use `IEnumerable<T>` and `yield return`; do not implement custom iterators manually.
- **State** — model state as objects or discriminated unions (C# records + pattern matching) rather than flag fields.

## What to avoid
- Do not apply a pattern just to follow the pattern — YAGNI applies.
- Do not name classes `*Manager`, `*Handler`, `*Helper` without a GoF pattern intent behind them.
- Singleton via `static` fields is forbidden — register as scoped/singleton in the DI container.
