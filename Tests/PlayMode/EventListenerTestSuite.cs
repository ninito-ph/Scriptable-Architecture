using FluentAssertions;
using Ninito.ScriptableArchitecture.Events;
using NUnit.Framework;
using UnityEngine;

namespace Tests.PlayMode.Events
{
    internal sealed class EventListenerTestSuite
    {
        [TestFixture]
        private sealed class EventListenerTests
        {
            private GameEvent _gameEvent;
            private EventListener _listener;

            [SetUp]
            public void Setup_EventListener()
            {
                _gameEvent = ScriptableObject.CreateInstance<GameEvent>();

                _listener = Object.Instantiate(new GameObject()).AddComponent<EventListener>();
                _listener.GameEvent = _gameEvent;
            }

            [Test]
            public void SetGameEvent_ToNewGameEvent_ShouldAddListenerToEventsListenerList()
            {
                _gameEvent.Listeners.Should().Contain(_listener);
            }

            [Test]
            public void SetGameEvent_ToNull_ShouldRemoveListenerFromEventsListenerList()
            {
                _listener.GameEvent = null;

                _gameEvent.Listeners.Should().NotContain(_listener);
            }

            [Test]
            public void InvokeEvent_WithListenerAdded_ShouldTriggerListenerUnityEvent()
            {
                // Arrange
                bool eventWasRaised = false;
                void Action() { eventWasRaised = true; }

                // Act
                _listener.UnityEvent.AddListener(Action);
                _gameEvent.Invoke();

                // Assert
                eventWasRaised.Should().BeTrue();
            }
        }
        
        [TestFixture]
        private sealed class GenericEventListenerTests
        {
            private IntEvent _genericGameEvent;
            private IntEventListener _listener;

            [SetUp]
            public void Setup_GenericEventListener()
            {
                _genericGameEvent = ScriptableObject.CreateInstance<IntEvent>();
                _genericGameEvent.Value = 1;

                _listener = Object.Instantiate(new GameObject()).AddComponent<IntEventListener>();
                _listener.GameEvent = _genericGameEvent;
            }

            [Test]
            public void SetGameEvent_ToNewGameEvent_ShouldAddGenericListenerToEventsListenerList()
            {
                _genericGameEvent.Listeners.Should().Contain(_listener);
            }

            [Test]
            public void SetGameEvent_ToNull_ShouldRemoveGenericListenerFromEventsListenerList()
            {
                _listener.GameEvent = null;

                _genericGameEvent.Listeners.Should().NotContain(_listener);
            }

            [Test]
            public void InvokeEvent_WithImplicitValue_ShouldTriggerListenerUnityEventWithImplicitValue()
            {
                // Arrange
                int counter = 0;
                void IncrementCounter(int incrementAmount) { counter += incrementAmount; }

                // Act
                _listener.UnityEvent.AddListener(IncrementCounter);
                _genericGameEvent.Invoke();

                // Assert
                counter.Should().Be(1);
            }
            
            [Test]
            public void InvokeEvent_WithExplicitValue_ShouldTriggerListenerUnityEventWithExplicitValue()
            {
                // Arrange
                int counter = 0;
                void IncrementCounter(int incrementAmount) { counter += incrementAmount; }

                // Act
                _listener.UnityEvent.AddListener(IncrementCounter);
                _genericGameEvent.Invoke(2);

                // Assert
                counter.Should().Be(2);
            }
        }
    }
}