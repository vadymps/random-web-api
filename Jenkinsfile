pipeline {
  agent any
  
  stages { 
    stage("build") {
      steps {
       echo "build ngrok 2" 
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
