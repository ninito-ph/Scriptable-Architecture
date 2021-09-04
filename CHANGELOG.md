# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [v1.2.0-stable] - Quiet Dust Release - 2021-09-04
### Changed
- Moved sample scripts to samples assembly definition.

## [v1.1.0-stable] - Polished Shadow Release - 2021-07-30
### Added
- Added NSubstitute and FluentAssertions to Unit Tests.
- Added ScriptableActions, a convenient way to write modularized behavior, with support for up to four arguments.
- Added RuntimeSets and RuntimeSetModifier, as a convient replacement for depency fulfilment using Singletons, with a GameObject RuntimeSet included.
- Added ScriptableEnums, a convenient way to handle designer-friendly and highly extensible enums.
### Changed
- Moved all project classes to Ninito.ScriptableArchitecture namespace.
- Fully rewrote all Unit Tests for better readability.
### Fixed
- Fixed critical bug in which EventListeners would not properly subscribe to their events on enter runtime.
- Added null check to GameEvents calling their listeners.

## [v1.0.2-stable] - Patient Bird Release - 2021-08-30
### Fixed
- Improved performance in asset renamer window.

## [v1.0.1-stable] - Snowy Water Release - 2021-04-19
### Fixed
- Fixed bug in which runtime OnChangeEvents would not be updated properly when entering playmode.