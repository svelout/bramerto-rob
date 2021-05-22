module Events =

    /// First, create instance of Event object that consists of subscription point (event.Publish) and event trigger (event.Trigger).
    let simpleEvent = new Event<int>()

    // Next, add handler to the event.
    simpleEvent.Publish.Add(
        fun x -> printfn "this handler was added with Publish.Add: %d" x)

    // Next, trigger the event.
    simpleEvent.Trigger(5)

    // Next, create an instance of Event that follows standard .NET convention: (sender, EventArgs).
    let eventForDelegateType = new Event<EventHandler, EventArgs>()

    // Next, add a handler for this new event.
    eventForDelegateType.Publish.AddHandler(
        EventHandler(fun _ _ -> printfn "this handler was added with Publish.AddHandler"))

    // Next, trigger this event (note that sender argument should be set).
    eventForDelegateType.Trigger(null, EventArgs.Empty)
