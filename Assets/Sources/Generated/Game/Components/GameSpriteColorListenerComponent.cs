//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SpriteColorListenerComponent spriteColorListener { get { return (SpriteColorListenerComponent)GetComponent(GameComponentsLookup.SpriteColorListener); } }
    public bool hasSpriteColorListener { get { return HasComponent(GameComponentsLookup.SpriteColorListener); } }

    public void AddSpriteColorListener(System.Collections.Generic.List<ISpriteColorListener> newValue) {
        var index = GameComponentsLookup.SpriteColorListener;
        var component = CreateComponent<SpriteColorListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpriteColorListener(System.Collections.Generic.List<ISpriteColorListener> newValue) {
        var index = GameComponentsLookup.SpriteColorListener;
        var component = CreateComponent<SpriteColorListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpriteColorListener() {
        RemoveComponent(GameComponentsLookup.SpriteColorListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpriteColorListener;

    public static Entitas.IMatcher<GameEntity> SpriteColorListener {
        get {
            if (_matcherSpriteColorListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpriteColorListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpriteColorListener = matcher;
            }

            return _matcherSpriteColorListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddSpriteColorListener(ISpriteColorListener value) {
        var listeners = hasSpriteColorListener
            ? spriteColorListener.value
            : new System.Collections.Generic.List<ISpriteColorListener>();
        listeners.Add(value);
        ReplaceSpriteColorListener(listeners);
    }

    public void RemoveSpriteColorListener(ISpriteColorListener value, bool removeComponentWhenEmpty = true) {
        var listeners = spriteColorListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveSpriteColorListener();
        } else {
            ReplaceSpriteColorListener(listeners);
        }
    }
}
