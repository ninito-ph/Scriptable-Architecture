using NUnit.Framework;
using UnityEngine;
using FluentAssertions;
using Ninito.ScriptableArchitecture.Variables;

namespace Tests.EditMode.Variables
{
    internal sealed class VariableTestSuite
    {
        [TestFixture]
        private sealed class ConstantModeReferenceTests
        {
            private IntReference _primaryReference;
            private IntReference _secondaryReference;

            [SetUp]
            public void Setup_References()
            {
                _primaryReference = new IntReference(1);
                _secondaryReference = new IntReference(1);
            }

            [Test]
            public void New_Reference_ShouldBeInConstantMode()
            {
                _primaryReference.UseConstant.Should().BeTrue();
            }

            [Test]
            public void Add_TwoConstantModeReferencesWithValueOne_ShouldBeTwo()
            {
                _primaryReference.Value += _secondaryReference;

                _primaryReference.Value.Should().Be(2);
            }
        }

        [TestFixture]
        private sealed class ReferenceModeReferenceTests
        {
            private readonly IntReference _primaryReference = new IntReference(0);
            private readonly IntReference _secondaryReference = new IntReference(0);

            [SetUp]
            public void Setup_References()
            {
                _primaryReference.Variable = ScriptableObject.CreateInstance<IntVariable>();
                _secondaryReference.Variable = ScriptableObject.CreateInstance<IntVariable>();

                // This step is done implicitly though the inspector
                _primaryReference.UseConstant = false;
                _secondaryReference.UseConstant = false;

                _primaryReference.Value = 1;
                _secondaryReference.Value = 1;
            }

            [Test]
            public void Reference_GivenVariable_VariableShouldNotBeNull()
            {
                _primaryReference.Variable.Should().NotBeNull();
            }

            [Test]
            public void Reference_WithVariableGivenValueOne_ShouldBeOne()
            {
                _primaryReference.Value.Should().Be(1);
            }

            [Test]
            public void Add_VariablesGivenValueOne_ShouldBeTwo()
            {
                _primaryReference.Value += _secondaryReference;

                _primaryReference.Value.Should().Be(2);
            }

            [Test]
            public void SetVariable_OfPrimaryReferenceToSecondaryReferenceVariable_BothReferencesHaveSameValues()
            {
                _secondaryReference.Value = 10;
                _primaryReference.Variable = _secondaryReference.Variable;

                _primaryReference.Value.Should().Be(_secondaryReference.Value);
            }
        }
    }
}