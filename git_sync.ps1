
   #cd repository-to-mirror.git
    #git remote add githuborigin https://ephremshiferaw:epsh3069@github.com/ephremshiferaw/FMS.git
    git remote set-url --push githuborigin https://ephremshiferaw:epsh3069@github.com/ephremshiferaw/FMS.git
   git push --mirror --force 
   write $LastExitCode
   