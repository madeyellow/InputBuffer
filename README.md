# What is it?
The `InputBuffer` allows store fact of input (*and also input value*) for a configurable time span & check if buffer isn't expired at any given moment.

## Where and why I should use it?

It's a perfect solution for buffering action input, such as pressing a jump button. If your player pressed it while not being grounded (e.g. right before landing) your logic may fail and player won't execute jump. *Frustrating, right?*

## Getting started

First of all declare input buffer:

```csharp
using MadeYellow.InputBuffer;


public SimpleInputBuffer jumpInputBuffer = new SimpleInputBuffer(); // Init input buffer
```

You may configure buffer **hold time** from Unity Editor by changing `holdTime` slider OR by passing `holdTime` argument to `InputBuffer` constructor.

You can choose between various types of `InputBuffer`:

* **SimpleInputBuffer** - best for buffering button presses *(in terms of Unity's InputSystem)*;
* **IntInputBuffer**, **FloatInputBuffer** - best for buffering axis 1D input *(in terms of Unity's InputSystem)*;
* **Vector2InputBuffer** - best for buffering gamepad stick input or any other 2D input;

After you've set up suitable `InputBuffer` you should use `.Set();` or `.Set(value);` method each time you want to buffer your input. You may do it like so:

```csharp
jumpInputBuffer.Set(); // Set input buffer when input happened
```

When you need to check if certain input is buffered or not you can perform a simple check:

```csharp
if (jumpInputBuffer.hasBuffer)
{
  jumpInputBuffer.Reset(); // Reset buffer since we most likely want to perform action required by input only once

  // Your code goes here, e.g. perform Jump action if input was buffered, etc.
}
```

**TIP:** It's best to perform those checks each frame in `Update()` or `LateUpdate()` method inside your MonoBehaviour, so you won't miss any input. It's super cheap in terms of performance.

## How to install Trackable to my Unity project?

Use the Unity Package Manager (in Unity’s top menu: **Window > Package Manager**), click "+" icon, select **"Add package from git URL"** and type URL of this repository.

## Get buffered value

If you created `InputBuffer` of any type **except** of `SimpleInputBuffer` (*because it doesn't stores any value, only the fact of the input*) you can call `.value` to retrieve current value of input.

```csharp
var vectorBuffer = new Vector2InputBuffer();

vectorBuffer.Set(Vector2.one);

Debug.Log(vectorBuffer.value); // Will log (1.00, 1.00)
```

## Recomendations

* **Don't** reuse single `InputBuffer` instance for various input actions: one instance for *jumping*, another for *dashing*, etc;
* **Use** `.hasBuffer` check each frame in order not to miss a frame where you might execute your buffered action;

## Having trouble or a feature request?

Create an issue and I'll do my best to help you or add a new usefull feature to that package.
