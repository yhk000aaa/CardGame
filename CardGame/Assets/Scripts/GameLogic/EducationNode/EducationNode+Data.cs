using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class EducationNode//游戏添加数据
{
    public EducationData mainData { get; private set; }

    void startData()
    {
        this.mainData = new EducationData();
        this.mainData.educationNode = this;
        this.mainData.start();
    }

    void updateData(float dt)
    {
        this.mainData.update(dt);
    }

    void stopData()
    {
        this.mainData.stop();
    }
}
