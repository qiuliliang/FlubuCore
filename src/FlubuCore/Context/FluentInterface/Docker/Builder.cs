
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker.Builder;

namespace FlubuCore.Context.FluentInterface.Docker
{
    public class Builder
    {  
        
            
        /// <summary>
        /// Build an image from a Dockerfile
        /// </summary>
            public DockerBuilderBuildTask BuilderBuild(string pathOrURL)
            {
                return new DockerBuilderBuildTask(pathOrURL);
            }


            
        /// <summary>
        /// Remove build cache
        /// </summary>
            public DockerBuilderPruneTask BuilderPrune()
            {
                return new DockerBuilderPruneTask();
            }

        
    }
}

