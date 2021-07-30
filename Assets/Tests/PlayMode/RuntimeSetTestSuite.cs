using System;
using System.Collections.Generic;
using FluentAssertions;
using Ninito.ScriptableArchitecture.RuntimeSets;
using NUnit.Framework;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Tests.PlayMode.Events
{
    internal sealed class RuntimeSetTestSuite
    {
        [TestFixture]
        private sealed class RuntimeSetTests
        {
            private GameObjectRuntimeSet _set;
            private GameObject _gameObject;

            [SetUp]
            public void Setup_EventListener()
            {
                _set = ScriptableObject.CreateInstance<GameObjectRuntimeSet>();
                _gameObject = new GameObject();
            }

            [Test]
            public void Add_NewGameObject_ShouldBeAbleToGetGameObject()
            {
                _set.Add("Test", _gameObject);

                _set.Get("Test").Should().Be(_gameObject);
            }
            
            [Test]
            public void Remove_GameObject_ShouldNotBeAbleToGetGameObject()
            {
                _set.Add("Test", _gameObject);
                _set.Remove("Test");
                
                _set.TryToGet("Test", out _gameObject).Should().BeFalse();
            }
            
            [Test]
            public void Get_NonExistentGameObject_ShouldThrowKeyNotFoundException()
            {
                _set.Add("Test", _gameObject);
                _set.Remove("Test");
                Action getGameObject = () => _set.Get("Test");

                getGameObject.Should().Throw<KeyNotFoundException>();
            }
        }
    }
}