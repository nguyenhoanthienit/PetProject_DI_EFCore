pipeline {
    agent any 
    stages {
        stage('Static Analysis') {
            steps {
                echo 'Run the static analysis to the code' 
            }
        }
        stage('Compile') {
            steps {
                echo 'Compile the source code' 
            }
        }
        stage('Security Check') {
            steps {
                echo 'Run the security check against the application' 
            }
        }
        stage('Run Unit Tests') {
            steps {
                echo 'Run unit tests from the source code' 
            }
        }
        stage('Run Integration Tests') {
            steps {
                echo 'Run only crucial integration tests from the source code' 
            }
        }
        stage('Publish Artifacts') {
            steps {
                echo 'Save the assemblies generated from the compilation' 
            }
        }
        stage('SCM') {
            checkout poll: false, scm: [$class: 'GitSCM', branches: [[name: 'master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[url: 'https://github.com/nguyenhoanthienit/PetProject_DI_EFCore.git']]]
        }
        stage('SonarQube Analysis') {
            sh "/home/jenkins/tools/hudson.plugins.sonar.SonarRunnerInstallation/sonarqubescanner/bin/sonar-scanner -Dsonar.host.url=http://192.168.0.14:9000 -Dsonar.projectName=meanstackapp -Dsonar.projectVersion=1.0 -Dsonar.projectKey=meanstack:app -Dsonar.sources=. -Dsonar.projectBaseDir=/home/jenkins/workspace/sonarqube_test_pipeline"
        }
    }
}
