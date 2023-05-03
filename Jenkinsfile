pipeline {
  agent any
  
  stages { 
    stage("build") {
      steps {
       echo "build" 
      }
    }
    
    stage("test") {
      steps {
       echo "test"
        sh 'dotnet restore'
        sh 'dotnet build'
        sh 'dotnet test'
      }
    }
    
    stage("deploy") {
      steps {
       echo "deploy" 
      }
    }
  }
}
