pipeline {
  agent any
  
  stages { 
    stage("build") {
      steps {
       echo "build ngrok 4" 
      }
    }
    
    stage("test") {
      steps {
       echo "test"
       //bat 'dotnet restore'
       //bat 'dotnet build'
       //bat 'dotnet test'
      }
    }
    
    stage("deploy") {
      steps {
       echo "deploy" 
      }
    }
  }
}
