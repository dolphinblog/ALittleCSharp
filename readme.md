###这个仓库是在Github客户端附带的Git Bash命令行中创建的，没有使用网页端或客户端来创建仓库
###步骤
* 在本地创建好的仓库目录中，Git Bash中输入：`curl -u 'username' https://api.github.com/user/repos -d '{"name":"RepoName"}'`,其中，username是你的用户名，RepoName是你想命名的仓库名。
这条命令执行后#输入密码#就创建成功了，会有仓库相关信息的#回显#。

* 接着，就可以添加远程仓库并Push:
`git remote add origin git@github.com:username/RepoName.git` 添加远程仓库，仓库名称为`origin`

* 接着，`git push origin master` 将本地仓库的master分支推到远程仓库origin上面

> 参考http://www.tuicool.com/articles/biQBRfR