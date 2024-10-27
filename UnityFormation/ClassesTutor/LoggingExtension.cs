using Unity.Builder;
using Unity.Extension;

public class LoggingExtension : UnityContainerExtension
{
    protected override void Initialize()
    {
        // Ajout d'un comportement personnalisé (journalisation) à chaque résolution
        Context.Strategies.Add(new LoggingStrategy(), UnityBuildStage.PostInitialization);
    }
}