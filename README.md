# What is it?
The `InputBuffer` allows store fact of input (*and also input value*) for a configurable time span & check if buffer isn't expired at any given moment.

## Getting started

First of all declare input buffer:

```csharp
using MadeYellow.InputBuffer;


public SimpleInputBuffer jumpInputBuffer = new SimpleInputBuffer(); // Init input buffer
```

You may configure buffer hold time from Unity editor by changing `holdTime` slider OR by passing `holdTime` argument to `InputBuffer` constructor.

You can choose between various types of `InputBuffer`:

* **SimpleInputBuffer** - best for buffering buttons *(in terms of Unity's InputSystem)*;
* **IntInputBuffer**, **FloatInputBuffer** - best for buffering axis *(in terms of Unity's InputSystem)*;
* **Vector2InputBuffer** - best for buffering gamepad stick input;

After initialization of appropiate `InputBuffer` on input recieving you should use `.Set();` or `.Set(value);` method:

```csharp
jumpInputBuffer.Set(); // Set input buffer when input happened
```

And when you need to check if certain input has buffered value you can perform a simple check:

```csharp
if (jumpInputBuffer.hasBuffer)
{
  jumpInputBuffer.Reset(); // Reset buffer since we most likely want to perform action required by input only once

  // Your code goes here
}
```

## How to install Trackable to my Unity project?

Use the Unity Package Manager (in Unity’s top menu: **Window > Package Manager**), click "+" icon, select **"Add package from git URL"** and type URL of this repository.

## Retrieving input value

If you inited `InputBuffer` of any type **except** of `SimpleInputBuffer` (*because it doesn't stores any value, only fact of input*) you can call `.value` to retrieve current value of input.

```csharp
var vectorBuffer = new Vector2InputBuffer();

vectorBuffer.Set(Vector2.one);

Debug.Log(vectorBuffer.value); // Will log (1.00, 1.00)
```

## Recomendations

* **Don't** reuse single `InputBuffer` instance for various input actions: one instance for *jumping*, another for *dashing*, etc.

## Having trouble or a feature request?

Create an issue and I'll do my best to help you or add a new usefull feature to that package.
