# Changelog

## Future Changes
### Non breaking changes
### Breaking changes
-Organize Components folder
-Organize utility scripts
-Separate out abstract classes

## MonoSingleton changees [0.0.6] - 2023-10-01 - Changed Init method to virtual to prevent empty methods impliemented in manager classes that do not require method
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