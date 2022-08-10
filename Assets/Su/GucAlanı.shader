Shader "Unlit/Deneme"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _RefractTex ("Texture", 2D) = "white" {}
        _Density("Density",Range(0,1)) = 1
    }
    SubShader
    {
        Tags {"Queue"="Transparent" "RenderType"="Transparent" }
        LOD 100

        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
     

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            sampler2D _RefractTex;
            fixed _Density;
            // float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                // o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 uvs = i.uv;
                uvs.x *=1;
                uvs.y *=1;

                // return fixed4(uvs,0,1);

                fixed shifter = tex2D(_RefractTex, i.uv + _Time.x).r;
                fixed shifter2 = tex2D(_RefractTex, i.uv + (_Time.x *0.3f)).r;
                shifter *= _Density - 0.6f;
                shifter2 *= _Density;
                fixed4 col = tex2D(_MainTex, uvs + shifter + shifter2);


                col.b *= (1+shifter) ;
                col.b *= (1+shifter2)  ;
                col.r *= 0.0f; 
                col.a = 0.6f;

                return col;
            }
            ENDCG
        }
    }
}
