# Changelog

## Future Changes
### Non breaking changes
### Breaking changes
-Organize Components folder
-Organize utility scripts
-Separate out abstract classes

## Animation Controller and Collision Sensor changes [0.0.14] 2024-01-18 - Modified FPSAnimationControllerBase to be more friendly with child classes
### Added
-Components
    --CollisionSensor3D
        ---Added a 3D version of the collision sensor
### Modified
-Components
    --FPSAnimationControllerBase
        ---Modifed animation string hashes from private to protected
        ---Added a set speed function to enable direct control of the 
-Change log
    ---Corrected v0.0.12 as it was stating changes were to monosingelton instead of helper methods


## HelperMethods hotfix [0.0.13] 2023-11-09 - Fixed issue where FindAndAssignComponent was giving compile error
### Modified
-Utility Scripts
    --HelperMethods
        ---Added monobehaviour requirement to FindAndAssignComponent function as T needed to derive monobehaviour
-Change log
    ---Corrected v0.0.12 as it was stating changes were to monosingelton instead of helper methods

## HelperMethods changes [0.0.12] 2023-11-09 - Removed requirement for component check component to derive from monobehaviour
### Modified
-Utility Scripts
    --HelperMethods
        ---Removed monobehaviour requirement from CheckAndAssignComponent functions


## GroundCheck2D changes [0.0.11] 2023-10-16 - Modified the GroundCheck script to use gizmos instead of debug draw lines
### Modified
-Components
    --GroundCheck2D
        ---Added bool "showGizmos", added a gizmo to draw lines and change colour if object is hit. Removed the debug drawing from the runtime methods

## MonoSingleton changes [0.0.10] 2023-10-16 - Modified the destroyOnLoad variable default to destorying objects on load
### Modified
-Utility Scripts
    --MonoSingleton
        ---Changed destoryOnLoad variable to dontDestroyOnLoad so objects default to destroyingOnLoad

## SpawnPoint changes [0.0.9] 2023-10-02 - Added a rotation property to spawnpoints to help create more readable code
### Modified
-Components
    --SpawnPoint
        ---Added a rotation property

## AudioData fixes [0.0.8] 2023-10-02 - Fixed issue where audio data was using the inbuilt Unity AudioType instead of a custom enum, added SoundCategory enum
### Added
-Audio
    --SoundCategory
        --Created enum with several types (Music, UI, Player, Enemy, Effect, Feedback)
### Modified
-Audio
    --AudioData
        ---Replace AudioType parameter with SoundCategory

## MonoSingleton changes pt2 [0.0.7] 2023-10-01 - Changed the instance to proctected instead of private to allow child classes to override the instance type
### Modified
-Utility Scripts
    --MonoSingleton
            ---Changed _instance variable from private to protected

## MonoSingleton changes [0.0.6] - 2023-10-01 - Changed Init method to virtual to prevent empty methods impliemented in manager classes that do not require method
### Modified
-Utility Scripts
    --MonoSingleton
        ---Changed Init method from abstract to virtual

## Samples assembly fix [0.0.5] - 2023-08-19 - Created assembly definitions in child folder
### Modified
-FrozenPhoenixExamples
    --UIExamples
        --Created assembly definitions


## Samples hot fix [0.0.4] - 2023-08-19 - Rearranged samples folder and added Assembly Definition to allow example scripts to work
### Modified
-Samples
    --Renamed FrozenPhoenixExamples
    --Moved TypeWriter example into UI examples folder
### Added
-Assembly Definition for FrozenPhoenixExamples folder

## Changelog Patch [0.0.3] - 2023-08-19 - Fixed issue with changelog meta file and samples folder
### Added
-Changelog meta file
### Modidied
-Changelog
    --Updates samples path


## Samples Patch [0.0.2] - 2023-08-19 - Introduced a samples folder for testing
### Added
-Samples
    --TypeWriterExample

## Initial Release [0.0.1] - 2023-08-19 - Imported all current Frozen Phoenix Scripts and created package
### Added
-Audio
    --AudioData
-Components
    --CollisionSensor2D
    --DestroyAfterTime
    --DontDestroyOnLoad
    --FPSAnimationController
    --FPSAnimationEventListener
    --FPSGenericAnimationController
    --GroundCheck2D
    --LookAtCamera
    --PlayerEventTriggerOnCollision
    --QuadDirectionalCollisionChecker2D
    --SafeAreaVerticalResizer
    --SpawnPoint
-DataStructures
    --FloatRange
    --IntRange
-UtilityScripts
    --ConversionMethods
    --HelperMethods
    --LoopingElementShuffler
    --MonoSingleton
    --UIUtilities