# ❓ What is it?
Simple yet effective input buffering with **just 4 lines of code!** ⚡
Never miss player actions again - perfect for jumps, dashes, and combo moves.

Check if buffer isn't expired at any given moment, configure buffer's lifetime, cache input values & etc.

## 💡 Why Use Input Buffering?

*Eliminate frustrating gameplay moments!*

When players press jump **just before landing**, your logic might ignore it.
**This solution**: Buffers inputs so they execute when conditions are right!

```
// Problem solved in 3 simple steps:
jumpBuffer.Set();          // 1. Buffer on player input
if (jumpBuffer.HasBuffer)  // 2. Check when it's needed
    PerformJump();         // 3. Execute perfectly!
```

# 💾 Installation
* Open **Unity Package Manager** (Window > Package Manager) OR (Window > Package Management > Package Manager) in **Unity 6**;
* Click "+" → "Add package from git URL";
* Paste this **repo's URL**;
* Hit **Install**;

# 🚀 Getting started
## Step 1: Define buffers
First of all declare input buffer:

```csharp
using MadeYellow.InputBuffer;

public SimpleInputBuffer jumpInputBuffer = new SimpleInputBuffer(); // Init input buffer
```

You can choose between various types of `InputBuffer`:

* `SimpleInputBuffer` - best for buffering button presses *(in terms of Unity's InputSystem)*;
* `IntInputBuffer`, `FloatInputBuffer` - best for buffering axis 1D input *(in terms of Unity's InputSystem)*;
* `Vector2InputBuffer` - best for buffering gamepad stick input or any other 2D input;

## Step 2: Buffer input
You may configure buffer **hold time** from Unity Editor by changing `holdTime` slider OR by passing `holdTime` argument to `InputBuffer` constructor.

After you've set up suitable `InputBuffer` you should use `.Set();` or `.Set(value);` method each time you want to buffer your input. You may do it like so:

```csharp
jumpInputBuffer.Set(); // Set input buffer when input happened
```

## Step 3: Check against the buffer
When you need to check if certain input **is buffered or not** you can perform a simple & performant check:

```csharp
if (jumpInputBuffer.hasBuffer)
{
  jumpInputBuffer.Reset(); // Reset buffer since we most likely want to perform action required by input only once

  // Your code goes here, e.g. perform Jump action if input was buffered, etc.
}
```

**TIP:** It's best to perform those checks each frame in `Update()` or `LateUpdate()` method inside your MonoBehaviour, so you won't miss any input. It's super cheap in terms of performance.

# Getting the buffered value

If you created `InputBuffer` of any type **except** of `SimpleInputBuffer` (*that one doesn't store any value at all, only the fact of the input*) you can call `.value` to retrieve current value of input.

```csharp
var vectorBuffer = new Vector2InputBuffer();

vectorBuffer.Set(Vector2.one);

Debug.Log(vectorBuffer.value); // Will log (1.00, 1.00)
```

# ✅ Recomendations

* **Don't** reuse single `InputBuffer` instance for various input actions: one instance for *jumping*, another for *dashing*, etc;
* **Use** `.hasBuffer` check each frame in order not to miss a frame where you might execute your buffered action;

# ⚡ Why You’ll Love It
* 🧠 **Easy to use** – pick a right buffer and use it right away;
* 🚀 **Great performance** – buffers are greatly optimized under the hood;
* 💎 **Clean syntax** – `.Set()` and `.Reset()` for buffering, `.hasBuffer` for conditions;
* 📦 **Tiny & dependency-free** – Minimal footprint;
* 
# Want me to add something OR found a bug?

Please add an issue and describe your feature request or bug. I will add a feature if consider it usefull, and for sure will fix bugs, 'cause I'm using that package myself in my games.
