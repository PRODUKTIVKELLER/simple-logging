# Simple Logging

**Simple Logging** is a thin wrapper around the Unity logging system that helps you write cleaner logs.

## Example

```csharp
private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

...

Log.Error("Could not find leaderboard with name {}.", _leaderboardName);
```

## Getting Started

Install **Simple Logging** using the **Unity Package Manager**:

`https://github.com/PRODUKTIVKELLER/simple-logging.git`
